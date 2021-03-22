using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitAddModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiSceneprodBenefitAddModel : AlipayObject
    {
        /// <summary>
        /// 权益ID，创建权益时返回的ID
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 追加的预算金额
        /// </summary>
        [JsonPropertyName("budget_amount")]
        public long BudgetAmount { get; set; }

        /// <summary>
        /// 外部业务号，幂等ID
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 创建权益的支付宝商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 调用方来源
        /// </summary>
        [JsonPropertyName("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 上游权益id
        /// </summary>
        [JsonPropertyName("upper_benefit_id")]
        public string UpperBenefitId { get; set; }

        /// <summary>
        /// 上游业务商家id
        /// </summary>
        [JsonPropertyName("upper_seller_id")]
        public string UpperSellerId { get; set; }
    }
}
