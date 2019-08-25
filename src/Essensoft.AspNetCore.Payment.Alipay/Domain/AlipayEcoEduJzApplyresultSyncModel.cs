using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduJzApplyresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduJzApplyresultSyncModel : AlipayObject
    {
        /// <summary>
        /// 报名编号（通过调用报名信息同步接口返回）
        /// </summary>
        [JsonProperty("apply_third_id")]
        public string ApplyThirdId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("audit_remark")]
        public string AuditRemark { get; set; }

        /// <summary>
        /// 报名结果状态
        /// </summary>
        [JsonProperty("listing_status")]
        public string ListingStatus { get; set; }
    }
}
