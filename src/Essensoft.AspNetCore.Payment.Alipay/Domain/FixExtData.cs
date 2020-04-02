using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FixExtData Data Structure.
    /// </summary>
    public class FixExtData : AlipayObject
    {
        /// <summary>
        /// 生态协同平台中，扩展信息的key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 生态协同平台中，扩展信息的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
