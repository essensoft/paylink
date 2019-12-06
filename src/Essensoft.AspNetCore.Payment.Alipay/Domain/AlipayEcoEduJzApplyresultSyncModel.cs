using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduJzApplyresultSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoEduJzApplyresultSyncModel : AlipayObject
    {
        /// <summary>
        /// 报名编号（通过调用报名信息同步接口返回）
        /// </summary>
        [JsonPropertyName("apply_third_id")]
        public string ApplyThirdId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("audit_remark")]
        public string AuditRemark { get; set; }

        /// <summary>
        /// 报名结果状态
        /// </summary>
        [JsonPropertyName("listing_status")]
        public string ListingStatus { get; set; }
    }
}
