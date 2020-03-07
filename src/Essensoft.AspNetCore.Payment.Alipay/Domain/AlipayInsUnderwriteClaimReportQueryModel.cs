using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsUnderwriteClaimReportQueryModel Data Structure.
    /// </summary>
    public class AlipayInsUnderwriteClaimReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 理赔申请报案号，通过理赔申请【alipay.ins.scene.claim.apply】接口的返回字段claim_report_no获取
        /// </summary>
        [JsonPropertyName("claim_report_no")]
        public string ClaimReportNo { get; set; }
    }
}
