using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneMobileScreenRefundModel Data Structure.
    /// </summary>
    public class AlipayInsSceneMobileScreenRefundModel : AlipayObject
    {
        /// <summary>
        /// 请求渠道来源
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 退保保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }
    }
}
