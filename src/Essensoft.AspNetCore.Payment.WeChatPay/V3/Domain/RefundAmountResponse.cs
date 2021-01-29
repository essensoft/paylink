using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 退款金额信息
    /// </summary>
    public class RefundAmountResponse : WeChatPayObject
    {
        /// <summary>
        /// 订单金额
        /// 订单总金额，单位为分。
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// 退款金额
        /// 退款标价金额，单位为分，可以做部分退款。
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("refund")]
        public int Refund { get; set; }

        /// <summary>
        /// 用户支付金额
        /// 现金支付金额，单位为分，只能为整数。
        /// 示例值：90
        /// </summary>
        [JsonPropertyName("payer_total")]
        public int PayerTotal { get; set; }

        /// <summary>
        /// 用户退款金额
        /// 退款给用户的金额，不包含所有优惠券金额。
        /// 示例值：90
        /// </summary>
        [JsonPropertyName("payer_refund")]
        public int PayerRefund { get; set; }

        /// <summary>
        /// 应结退款金额
        /// 去掉非充值代金券退款金额后的退款金额，单位为分，退款金额=申请退款金额-非充值代金券退款金额，退款金额<=申请退款金额。
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("settlement_refund")]
        public int SettlementRefund { get; set; }

        /// <summary>
        /// 应结订单金额
        /// 应结订单金额=订单金额-免充值代金券金额，应结订单金额<=订单金额，单位为分。
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("settlement_total")]
        public int SettlementTotal { get; set; }

        /// <summary>
        /// 优惠退款金额
        /// 优惠退款金额<=退款金额，退款金额-代金券或立减优惠退款金额为现金，说明详见代金券或立减优惠，单位为分。
        /// 示例值：10
        /// </summary>
        [JsonPropertyName("discount_refund")]
        public int DiscountRefund { get; set; }

        /// <summary>
        /// 退款币种
        /// 符合ISO 4217标准的三位字母代码，目前只支持人民币：CNY。
        /// 示例值：CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
