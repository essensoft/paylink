using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneMobileScreenApplyResponse.
    /// </summary>
    public class AlipayInsSceneMobileScreenApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 投保外部业务单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保单详情地址
        /// </summary>
        [JsonPropertyName("policy_url")]
        public string PolicyUrl { get; set; }
    }
}
