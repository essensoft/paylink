using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SignRestrictInfo Data Structure.
    /// </summary>
    public class SignRestrictInfo : AlipayObject
    {
        /// <summary>
        /// 产品码，支付宝定义的产品码
        /// </summary>
        [JsonPropertyName("restrict_product")]
        public string RestrictProduct { get; set; }

        /// <summary>
        /// 受限的原因
        /// </summary>
        [JsonPropertyName("restrict_reason")]
        public string RestrictReason { get; set; }

        /// <summary>
        /// 受限原因编码
        /// </summary>
        [JsonPropertyName("restrict_reason_code")]
        public string RestrictReasonCode { get; set; }

        /// <summary>
        /// 受限版本，02-受限版 04-极速版
        /// </summary>
        [JsonPropertyName("restrict_version")]
        public string RestrictVersion { get; set; }
    }
}
