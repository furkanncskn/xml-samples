using System;
using System.Linq;
using System.Text;

namespace XmlSamples.Helper
{
    public static class Convert
    {
        public static string FromObjectToString<T>(this T instance) where T : class, new()
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
    }
}
