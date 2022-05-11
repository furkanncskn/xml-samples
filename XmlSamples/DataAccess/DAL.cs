using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace XmlSamples.DataAccess
{
    public static class DAL<T> where T : class, new()
    {
        public static T? FirstElementFromXmlToInstance(string uri)
        {
            XElement xElement = XElement.Load(uri);

            var firstElement = xElement.Descendants("Table").FirstOrDefault();

            if (firstElement == null) { throw new NullReferenceException(); }

            Object[] values = new Object[firstElement.Elements().Count()];

            int i = 0;
            foreach (XElement element in firstElement.Descendants())
            {
                if (element == null) throw new NullReferenceException();

                values[i++] = element.Value;
            }

            Type type = typeof(T);

            PropertyInfo[] properties = type.GetProperties();

            List<string> PropertyNames = properties.Select(x => x.Name).ToList();

            List<Type> PropertyTypes = properties.Select(x => x.PropertyType).ToList();

            T instance = new();

            i = 0;
            foreach (PropertyInfo property in properties)
            {
                var obje = Convert.ChangeType(values[i], PropertyTypes[i]);

                property.SetValue(instance, obje);

                i++;
            }

            return instance;
        }

        public static T? FromXmlToInstanceById(string uri, int id)
        {
            try
            {
                Type type = typeof(T);

                var properties = type.GetProperties().ToList();

                List<Type> PropertyTypes = properties.Select(x => x.PropertyType).ToList();

                var keyPropertyName = string.Empty;

                properties.ForEach(item => { if (item.GetCustomAttributes<KeyAttribute>().Any()) { keyPropertyName = item.Name; } });

                if (keyPropertyName == string.Empty) throw new Exception("Invalid key propery name");

                XElement xElement = XElement.Load(uri);

                var elements = xElement.Descendants("Table");

                XElement? element = null;

                foreach (var item in elements)
                {
                    XElement? keyElement = item.Element(keyPropertyName);

                    if (keyElement == null) continue;

                    if (Convert.ToInt32(keyElement.Value) == id)
                    {
                        element = item;
                    }
                }

                if (element == null) { throw new Exception("Element is not null"); }

                Object[] values = new Object[element.Descendants().Count()];

                if (!(values.Length > 0)) throw new Exception("Not Found Element");

                int i = 0;
                foreach (XElement item in element.Descendants())
                {
                    if (item == null) throw new NullReferenceException();

                    values[i++] = item.Value;
                }

                T instance = new();

                i = 0;
                foreach (PropertyInfo property in properties)
                {
                    var obje = Convert.ChangeType(values[i], PropertyTypes[i]);

                    property.SetValue(instance, obje);

                    i++;
                }

                return instance;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
