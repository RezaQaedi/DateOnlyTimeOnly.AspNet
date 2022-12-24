using MD.PersianDateTime.Standard;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DateOnlyTimeOnly.AspNet.Converters
{
    public class PersianDateTimeJsonConverter : JsonConverter<PersianDateTime>
    {
        public override PersianDateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return PersianDateTime.Parse(reader.GetString()!);
        }

        public override PersianDateTime ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return PersianDateTime.Parse(reader.GetString()!);
        }

        public override void Write(Utf8JsonWriter writer, PersianDateTime value, JsonSerializerOptions options)
        {
            var isoDate = value.ToString("yyyy-MM-ddTHH:mm:ss");
            writer.WriteStringValue(isoDate);
        }

        public override void WriteAsPropertyName(Utf8JsonWriter writer, PersianDateTime value, JsonSerializerOptions options)
        {
            var isoDate = value.ToString("yyyy-MM-ddTHH:mm:ss");
            writer.WritePropertyName(isoDate);
        }
    }
}
