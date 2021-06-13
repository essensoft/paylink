using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationMobileApplyResponse.
    /// </summary>
    public class AlipayInsSceneApplicationMobileApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 保障卡短连
        /// </summary>
        [JsonPropertyName("card_url")]
        public string CardUrl { get; set; }

        /// <summary>
        /// 外部商户业务ID，必须唯一
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保险保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }
    }
}
