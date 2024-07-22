using Newtonsoft.Json;
using System;

namespace MagicLandExplorer
{
    public class DurationConverter : JsonConverter<int>
    {
        public override int ReadJson(JsonReader reader, Type objectType, int existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                string durationStr = (string)reader.Value;
                if (int.TryParse(new string(durationStr.TakeWhile(char.IsDigit).ToArray()), out int duration))
                {
                    return duration;
                }
            }
            throw new JsonReaderException($"Unable to parse duration value: {reader.Value}");
        }

        public override void WriteJson(JsonWriter writer, int value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
        }
    }
}
