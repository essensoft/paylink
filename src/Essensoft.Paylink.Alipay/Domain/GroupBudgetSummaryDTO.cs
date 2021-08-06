using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// GroupBudgetSummaryDTO Data Structure.
    /// </summary>
    public class GroupBudgetSummaryDTO : AlipayObject
    {
        /// <summary>
        /// 预算受益部门编码
        /// </summary>
        [JsonPropertyName("benefiting_dept")]
        public string BenefitingDept { get; set; }

        /// <summary>
        /// bg编码
        /// </summary>
        [JsonPropertyName("bg_code")]
        public string BgCode { get; set; }

        /// <summary>
        /// bu编码
        /// </summary>
        [JsonPropertyName("bu_code")]
        public string BuCode { get; set; }

        /// <summary>
        /// 预算科目编码
        /// </summary>
        [JsonPropertyName("budget_account")]
        public string BudgetAccount { get; set; }

        /// <summary>
        /// 集团预算年份
        /// </summary>
        [JsonPropertyName("budget_fy")]
        public string BudgetFy { get; set; }

        /// <summary>
        /// 集团预算编码，由GB开头
        /// </summary>
        [JsonPropertyName("group_budget_code")]
        public string GroupBudgetCode { get; set; }

        /// <summary>
        /// 预算编制部门编码
        /// </summary>
        [JsonPropertyName("making_dept")]
        public string MakingDept { get; set; }

        /// <summary>
        /// 剩余可用金额(单位：元)
        /// </summary>
        [JsonPropertyName("remain_amount")]
        public string RemainAmount { get; set; }
    }
}
