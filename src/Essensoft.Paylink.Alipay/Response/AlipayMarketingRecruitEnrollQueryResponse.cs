using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollQueryResponse.
    /// </summary>
    public class AlipayMarketingRecruitEnrollQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 报名ID
        /// </summary>
        [JsonPropertyName("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 报名信息
        /// </summary>
        [JsonPropertyName("enroll_info")]
        public RecruitEnrollInfo EnrollInfo { get; set; }

        /// <summary>
        /// 报名时间
        /// </summary>
        [JsonPropertyName("enroll_time")]
        public string EnrollTime { get; set; }

        /// <summary>
        /// 备注字段
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 招商方案ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 报名状态： AUDITING 审核中； ENABLED 通过 ； REJECTED 不通过 ； CLOSING 下线审核中 ； CLOSED 已下线；
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
