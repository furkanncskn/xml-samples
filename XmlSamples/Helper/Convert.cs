using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace XmlSamples.Helper
{
    public static class Convert
    {
        public static string FromObjectToString<T>(T instance) where T : class, new()
        {
            try
            {
                Type type = typeof(T);

                var properties = type.GetProperties();

                var propertyNames = properties.Select(properties => properties.Name).ToArray();

                var propertyTypes = properties.Select(properties => properties.PropertyType).ToArray();

                StringBuilder str = new();

                str.AppendLine(type.Name);

                foreach (var property in properties)
                {
                    str.AppendLine(property.Name + ": " + property.GetValue(instance, null));
                }

                return str.ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static List<T> FromArrayToList<T>(T[] param) where T : new()
        {
            try
            {
                Type type = typeof(T);

                var properties = type.GetProperties().ToList();

                var propertyNames = properties.Select(properties => properties.Name).ToList();

                T instance = new();

                List<T> list = new List<T>();

                foreach (var item in param)
                {
                    properties
                        .ForEach(prop => prop.SetValue(
                            obj: instance,
                            value: System.Convert.ChangeType(
                                value: prop.GetValue(item, null),
                                conversionType: prop.PropertyType)
                            )
                        );

                    list.Add(item);
                }

                return list;
            }
            catch (Exception)
            {
                return new List<T>();
            }
        }

        public static DataTable FromListToDataTable<T>(List<T> list) where T : class, new()
        {
            try
            {
                Type type = typeof(T);

                var properties = type.GetProperties().ToList();

                DataTable dt = new DataTable();

                properties.ForEach(prop => dt.Columns.Add(prop.Name, prop.PropertyType));

                foreach (var item in list)
                {
                    var row = dt.NewRow();

                    properties.ForEach((prop) => row[prop.Name] = prop.GetValue(item, null));

                    dt.Rows.Add(row);
                }

                return dt;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }
    }
}
