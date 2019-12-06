using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthousePublicrentApplyscheduleSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthousePublicrentApplyscheduleSyncModel : AlipayObject
    {
        /// <summary>
        /// 申请单进度列表
        /// </summary>
        [JsonPropertyName("apply_schedule_list")]
        public List<EcoApplySchedule> ApplyScheduleList { get; set; }

        /// <summary>
        /// 证件号-身份证号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 租客用户Id
        /// </summary>
        [JsonPropertyName("rent_id")]
        public string RentId { get; set; }
    }
}
