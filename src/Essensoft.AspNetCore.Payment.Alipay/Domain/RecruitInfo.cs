using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecruitInfo Data Structure.
    /// </summary>
    public class RecruitInfo : AlipayObject
    {
        /// <summary>
        /// 招商结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否参与门店参与了招商
        /// </summary>
        [JsonPropertyName("exclude_constraint_shops")]
        public bool ExcludeConstraintShops { get; set; }

        /// <summary>
        /// 招商方案id
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 招商开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 招商状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
