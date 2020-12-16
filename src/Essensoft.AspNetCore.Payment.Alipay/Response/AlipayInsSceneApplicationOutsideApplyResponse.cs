using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationOutsideApplyResponse.
    /// </summary>
    public class AlipayInsSceneApplicationOutsideApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 外部业务号(与入参调用外部业务号一致)
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保费(分)
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 风险等级  1:正常  2:关注  3:高风险  4:极高风险
        /// </summary>
        [JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 保额(分)
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public long SumInsured { get; set; }
    }
}
