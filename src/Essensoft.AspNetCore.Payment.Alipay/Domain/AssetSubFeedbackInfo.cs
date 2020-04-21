using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetSubFeedbackInfo Data Structure.
    /// </summary>
    public class AssetSubFeedbackInfo : AlipayObject
    {
        /// <summary>
        /// 返回的信息code
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回值的描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 具体的值，例如SN号
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
