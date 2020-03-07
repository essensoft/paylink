using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundDescriptionDTO Data Structure.
    /// </summary>
    public class RefundDescriptionDTO : AlipayObject
    {
        /// <summary>
        /// 本次支付用户实付的金额 = 应付金额 - 支付优惠中商家优惠金额 - 支付优惠中平台补贴金额
        /// </summary>
        [JsonPropertyName("buyer_amount")]
        public string BuyerAmount { get; set; }

        /// <summary>
        /// 失败原因编码
        /// </summary>
        [JsonPropertyName("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 口碑订单级优惠(特价菜、阶梯减)
        /// </summary>
        [JsonPropertyName("kb_order_discount")]
        public string KbOrderDiscount { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [JsonPropertyName("online_payment_no")]
        public string OnlinePaymentNo { get; set; }

        /// <summary>
        /// 本次应付金额=实际支付金额+支付级优惠金额
        /// </summary>
        [JsonPropertyName("payable_amount")]
        public string PayableAmount { get; set; }

        /// <summary>
        /// 支付单id
        /// </summary>
        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// 本次支付的支付方式，包括但不限于：(1) ALIPAY：支付宝(2) WECHAT：微信
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 退款状态，(1) SUCCESS表示退款成功 (2) PROCESSING表示退款中
        /// </summary>
        [JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 本次支付商户实收的金额 = 用户实付金额 + 平台补贴金额 = 本次订单应付金额 - 本次支付商家优惠金额
        /// </summary>
        [JsonPropertyName("seller_amount")]
        public string SellerAmount { get; set; }
    }
}
