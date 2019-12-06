using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务名称，和out_biz_no一起进行幂等控制
        /// </summary>
        [JsonPropertyName("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 立减出资类型,默认集分宝:  集分宝出资：POINT；  支付宝余额出资：BALANCE
        /// </summary>
        [JsonPropertyName("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 预算库使用结束时间，格式：yyyy-MM-dd mm:hh:ss
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 预算名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 预算创建业务号，和biz_from一起进行幂等控制
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 积分预算库ID,集分宝出资时必填
        /// </summary>
        [JsonPropertyName("out_budget_no")]
        public string OutBudgetNo { get; set; }

        /// <summary>
        /// 发行人支付宝登录账号
        /// </summary>
        [JsonPropertyName("publisher_logon_id")]
        public string PublisherLogonId { get; set; }

        /// <summary>
        /// 预算金额，单位：元
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
