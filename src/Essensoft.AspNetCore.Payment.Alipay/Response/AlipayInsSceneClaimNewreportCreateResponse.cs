using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneClaimNewreportCreateResponse.
    /// </summary>
    public class AlipayInsSceneClaimNewreportCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 保单单据号
        /// </summary>
        [JsonPropertyName("claim_report_no")]
        public string ClaimReportNo { get; set; }
    }
}
