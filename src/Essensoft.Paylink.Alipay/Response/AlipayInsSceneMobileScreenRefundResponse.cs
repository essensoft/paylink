using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneMobileScreenRefundResponse.
    /// </summary>
    public class AlipayInsSceneMobileScreenRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 退保保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 退保保费
        /// </summary>
        [JsonPropertyName("surrender_premium")]
        public string SurrenderPremium { get; set; }
    }
}
