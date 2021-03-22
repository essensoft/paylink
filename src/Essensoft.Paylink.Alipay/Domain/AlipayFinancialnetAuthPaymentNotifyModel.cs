using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthPaymentNotifyModel Data Structure.
    /// </summary>
    public class AlipayFinancialnetAuthPaymentNotifyModel : AlipayObject
    {
        /// <summary>
        /// 商品资源基础价值
        /// </summary>
        [JsonPropertyName("basic_amount")]
        public string BasicAmount { get; set; }

        /// <summary>
        /// 商品资源权益价值
        /// </summary>
        [JsonPropertyName("benefit_amount")]
        public string BenefitAmount { get; set; }

        /// <summary>
        /// 业务状态
        /// </summary>
        [JsonPropertyName("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 由平台分配，领取、消费的品类类型，有储值方案、商品、权益方案等
        /// </summary>
        [JsonPropertyName("commodity_type")]
        public string CommodityType { get; set; }

        /// <summary>
        /// 外部资源品类的id（长度<128）
        /// </summary>
        [JsonPropertyName("out_commodity_id")]
        public string OutCommodityId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 由平台分配，区分外部回调来源平台的身份
        /// </summary>
        [JsonPropertyName("platform_id")]
        public string PlatformId { get; set; }

        /// <summary>
        /// 业务流水号（非必填）
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// uuid，用于身份核验（选填）
        /// </summary>
        [JsonPropertyName("validate_token")]
        public string ValidateToken { get; set; }
    }
}
