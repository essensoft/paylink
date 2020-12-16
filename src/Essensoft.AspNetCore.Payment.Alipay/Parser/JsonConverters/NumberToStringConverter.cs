using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser.JsonConverters
{
    public class NumberToStringConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetInt64(out var l))
                {
                    return l.ToString();
                }
            }

            return reader.GetString();
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(value.AsSpan());
            }
        }
    }
}
