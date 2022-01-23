using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 退款金额信息
    /// </summary>
    public class RefundAmountResponse : WeChatPayObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        /// <remarks>
        /// 订单总金额，单位为分。
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        /// <remarks>
        /// 退款标价金额，单位为分，可以做部分退款。
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("refund")]
        public int Refund { get; set; }

        /// <summary>
        /// 退款出资账户及金额
        /// </summary>
        /// <remarks>
        /// 退款需要从指定账户出资时，传递此参数指定出资金额（币种的最小单位，只能为整数）。
        /// 同时指定多个账户出资退款的使用场景需要满足以下条件：
        ///   1、未开通退款支出分离产品功能；
        ///   2、订单属于分账订单，且分账处于待分账或分账中状态。
        /// 参数传递需要满足条件：
        /// 1、基本账户可用余额出资金额与基本账户不可用余额出资金额之和等于退款金额；
        /// 2、账户类型不能重复。
        /// 上述任一条件不满足将返回错误
        /// </remarks>
        [JsonPropertyName("from")]
        public List<RefundAmountFrom> From { get; set; }

        /// <summary>
        /// 用户支付金额
        /// </summary>
        /// <remarks>
        /// 现金支付金额，单位为分，只能为整数。
        /// <para>示例值：90</para>
        /// </remarks>
        [JsonPropertyName("payer_total")]
        public int PayerTotal { get; set; }

        /// <summary>
        /// 用户退款金额
        /// </summary>
        /// <remarks>
        /// 退款给用户的金额，不包含所有优惠券金额。
        /// <para>示例值：90</para>
        /// </remarks>
        [JsonPropertyName("payer_refund")]
        public int PayerRefund { get; set; }

        /// <summary>
        /// 应结退款金额
        /// </summary>
        /// <remarks>
        /// 去掉非充值代金券退款金额后的退款金额，单位为分，退款金额=申请退款金额-非充值代金券退款金额，退款金额&lt;=申请退款金额。
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("settlement_refund")]
        public int SettlementRefund { get; set; }

        /// <summary>
        /// 应结订单金额
        /// </summary>
        /// <remarks>
        /// 应结订单金额=订单金额-免充值代金券金额，应结订单金额&lt;=订单金额，单位为分。
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("settlement_total")]
        public int SettlementTotal { get; set; }

        /// <summary>
        /// 优惠退款金额
        /// </summary>
        /// <remarks>
        /// 优惠退款金额&lt;=退款金额，退款金额-代金券或立减优惠退款金额为现金，说明详见代金券或立减优惠，单位为分。
        /// <para>示例值：10</para>
        /// </remarks>
        [JsonPropertyName("discount_refund")]
        public int DiscountRefund { get; set; }

        /// <summary>
        /// 退款币种
        /// </summary>
        /// <remarks>
        /// 符合ISO 4217标准的三位字母代码，目前只支持人民币：CNY。
        /// <para>示例值：CNY</para>
        /// </remarks>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
