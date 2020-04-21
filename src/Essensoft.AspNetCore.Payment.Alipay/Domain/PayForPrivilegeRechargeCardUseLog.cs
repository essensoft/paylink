using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayForPrivilegeRechargeCardUseLog Data Structure.
    /// </summary>
    public class PayForPrivilegeRechargeCardUseLog : AlipayObject
    {
        /// <summary>
        /// 交易总金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易中权益金部分（配置膨胀方案时使用）
        /// </summary>
        [JsonPropertyName("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务类型，PAY(支付), REFUND(退款)
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 该字段已废弃，请勿使用
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 交易中本金部分
        /// </summary>
        [JsonPropertyName("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝统一用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
