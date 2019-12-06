using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EpElement Data Structure.
    /// </summary>
    public class EpElement : AlipayObject
    {
        /// <summary>
        /// 企业征信数据key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 企业征信数据value，字段长度不定。
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
