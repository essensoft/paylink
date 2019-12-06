using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtendFieldInfo Data Structure.
    /// </summary>
    public class ExtendFieldInfo : AlipayObject
    {
        /// <summary>
        /// 字段名
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        [JsonPropertyName("field_value")]
        public string FieldValue { get; set; }
    }
}
