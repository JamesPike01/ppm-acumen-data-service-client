using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Common
{
    /// <summary>Serialises DateTime? values as ISO 8601 UTC strings (yyyy-MM-ddTHH:mm:ssZ).</summary>
    public class DateTimeJsonConverter : JsonConverter<DateTime?>
    {
        private const string Format = "yyyy-MM-ddTHH:mm:ssZ";

        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            if (value.HasValue)
                writer.WriteValue(value.Value.ToUniversalTime().ToString(Format));
            else
                writer.WriteNull();
        }

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            if (reader.TokenType == JsonToken.String)
            {
                var s = reader.Value?.ToString();
                if (string.IsNullOrEmpty(s)) return null;
                if (DateTime.TryParse(s, null, System.Globalization.DateTimeStyles.RoundtripKind, out var dt))
                    return dt;
            }
            if (reader.TokenType == JsonToken.Date && reader.Value is DateTime d)
                return d;

            throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing DateTime");
        }
    }
}
