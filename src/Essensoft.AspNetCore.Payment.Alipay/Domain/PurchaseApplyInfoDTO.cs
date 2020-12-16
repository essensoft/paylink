using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PurchaseApplyInfoDTO Data Structure.
    /// </summary>
    public class PurchaseApplyInfoDTO : AlipayObject
    {
        /// <summary>
        /// 采购类目
        /// </summary>
        [JsonPropertyName("account_code")]
        public string AccountCode { get; set; }

        /// <summary>
        /// 预算周期
        /// </summary>
        [JsonPropertyName("begin_cycle")]
        public string BeginCycle { get; set; }

        /// <summary>
        /// 活动预算申请code
        /// </summary>
        [JsonPropertyName("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 活动预算id
        /// </summary>
        [JsonPropertyName("biz_budget_id")]
        public string BizBudgetId { get; set; }

        /// <summary>
        /// 业务类型 COMMISSION("COMMISSION", "返佣"), PURCHASE("PURCHASE", "采购"), PROMO("PROMO", "营销"),
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// PERCENTAGE("PERCENTAGE", "出资占比"), ORDER("ORDER", "自定义顺序");
        /// </summary>
        [JsonPropertyName("budget_strategy")]
        public string BudgetStrategy { get; set; }

        /// <summary>
        /// 预算周期结束时间
        /// </summary>
        [JsonPropertyName("end_cycle")]
        public string EndCycle { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 申请id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 活动预算池编码
        /// </summary>
        [JsonPropertyName("pool_code")]
        public string PoolCode { get; set; }

        /// <summary>
        /// 状态：CONFIG，CONFIG_DONE，CHECK，ACTIVE，HISTORY，CLOSE，DISCARD，INACTIVE
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 采购用途
        /// </summary>
        [JsonPropertyName("use")]
        public string Use { get; set; }
    }
}
