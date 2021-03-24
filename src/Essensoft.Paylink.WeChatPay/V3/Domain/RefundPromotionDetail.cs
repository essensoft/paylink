using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 优惠退款信息
    /// </summary>
    public class RefundPromotionDetail : WeChatPayObject
    {
        /// <summary>
        /// 券ID
        /// </summary>
        /// <remarks>
        /// 券或者立减优惠id。
        /// <para>示例值：109519</para>
        /// </remarks>
        [JsonPropertyName("promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// 优惠范围
        /// </summary>
        /// <remarks>
        /// GLOBAL：全场代金券
        /// SINGLE：单品优惠
        /// <para>示例值：SINGLE</para>
        /// </remarks>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        /// <remarks>
        /// 枚举值：
        /// COUPON：代金券，需要走结算资金的充值型代金券
        /// DISCOUNT：优惠券，不走结算资金的免充值型优惠券
        /// <para>示例值：DISCOUNT</para>
        /// </remarks>
        [JsonPropertyName("type")]

        public string Type { get; set; }

        /// <summary>
        /// 优惠券面额
        /// </summary>
        /// <remarks>
        /// 用户享受优惠的金额（优惠券面额=微信出资金额+商家出资金额+其他出资方金额 ），单位为分。
        /// <para>示例值：5</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 优惠退款金额
        /// </summary>
        /// <remarks>
        /// 优惠退款金额&lt;=退款金额，退款金额-代金券或立减优惠退款金额为用户支付的现金，说明详见代金券或立减优惠，单位为分。
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("refund_amount")]
        public int RefundAmount { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        /// <remarks>
        /// 优惠商品发生退款时返回商品信息。
        /// </remarks>
        [JsonPropertyName("goods_detail")]
        public List<RefundGoodsDetail> GoodsDetail { get; set; }
    }
}
