using System.Text.Json;
using System.Xml.Serialization;

namespace LibDataClean
{
    public class DataClean
    {
        public static void SerializeToJson<T>(T data, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, jsonString);
        }

        public static T DeserializeFromJson<T>(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        public static void SerializeToXml<T>(T data, string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var writer = new StreamWriter(filePath);
            serializer.Serialize(writer, data);
        }

        public static T DeserializeFromXml<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var reader = new StreamReader(filePath);
            return (T)serializer.Deserialize(reader);
        }
    }
}
