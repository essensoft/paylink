using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingRecruitEnrollCreateModel : AlipayObject
    {
        /// <summary>
        /// 报名信息
        /// </summary>
        [JsonPropertyName("enroll_info")]
        public RecruitEnrollInfo EnrollInfo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 要报名的招商方案ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}
