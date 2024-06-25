using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace Amax.InsurancePro.Domain.Common;

public static class Extensions
{
    public static DataTable AsDataTable<T>(this IEnumerable<T> data)
    {
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
        var table = new DataTable();
        foreach (PropertyDescriptor prop in properties)
        {
            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        }

        foreach (T item in data)
        {
            DataRow row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
            {
                row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            }
            table.Rows.Add(row);
        }
        return table;
    }

    public static string ToXml<T>(this List<T> list)
    {
        string xml = string.Empty;
        var serializer = new XmlSerializer(typeof(List<T>));
        var settings = new XmlWriterSettings();
        settings.Indent = true;
        settings.OmitXmlDeclaration = true;

        using (var stream = new MemoryStream())
        {
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, list);
                stream.Position = 0;
                xml = new StreamReader(stream).ReadToEnd();
            }
            stream.Dispose();
        }
        return xml;
    }

    public static string ToDescription(this Enum @enum)
    {
        try
        {
            var @string = @enum.ToString();

            var attribute =
                @enum.GetType()?
                     .GetField(@string)?
                     .GetCustomAttribute<DescriptionAttribute>(false);

            return attribute != null ? attribute.Description : @string;
        }
        catch
        {
            return string.Empty;
        }
    }

    public static IDictionary<string, string> ToDictionary(this Type type)
    {
        if (!type.IsEnum)
        {
            throw new InvalidCastException("'enumValue' is not an Enumeration!");
        }

        var names = Enum.GetNames(type);
        var values = Enum.GetValues(type);

        return Enumerable.Range(0, names.Length)
                         .Select(index => new
                         {
                             Key = names[index],
                             Value = (values.GetValue(index) as Enum).ToDescription()
                         })
                         .ToDictionary(k => k.Key, k => k.Value);
    }

    public static object GetValue<T>(this T obj, string propName)
    {
        object? value = default;
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

        var prop = properties.Find(propName, true);
        if (prop != null)
        {
            value = prop.GetValue(obj);
        }

        return value;
    }
}
