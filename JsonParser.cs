using System.IO;
using System.Text.Json;

namespace SilverspyCLI.Models
{
    public class JsonParser<T>
    {
        public static T FromJson(string filePath)
        {
            var rawJson = File.ReadAllText(filePath);
            var result = JsonSerializer.Deserialize<T>(rawJson, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return result;
        }
    }
}