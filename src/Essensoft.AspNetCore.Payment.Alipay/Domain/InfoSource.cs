using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InfoSource Data Structure.
    /// </summary>
    public class InfoSource : AlipayObject
    {
        /// <summary>
        /// 儿童信息来源的类型，目前支持name
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 信息来源的取值，比如type为name时，value对应儿童的姓名
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
