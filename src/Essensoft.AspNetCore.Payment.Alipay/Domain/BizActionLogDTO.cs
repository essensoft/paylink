using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizActionLogDTO Data Structure.
    /// </summary>
    public class BizActionLogDTO : AlipayObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务预算申请Code
        /// </summary>
        [JsonPropertyName("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 预算活动id
        /// </summary>
        [JsonPropertyName("biz_budget_id")]
        public string BizBudgetId { get; set; }

        /// <summary>
        /// 业务活动名称
        /// </summary>
        [JsonPropertyName("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// * 业务类型，      * COMMISSION: 返佣      * PURCHASE: 采购      * PROMO: 营销
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务活动唯一id
        /// </summary>
        [JsonPropertyName("biz_uk_id")]
        public string BizUkId { get; set; }

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
        /// 记录id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// BIZ_APPLY, 业务活动预算申请      *      *     BIZ_RETURN, 业务活动预算退回      *      *     BIZ_EXPIRE_RETURN, 业务活动预算过期退回
        /// </summary>
        [JsonPropertyName("modify_type")]
        public string ModifyType { get; set; }
    }
}
