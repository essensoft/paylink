using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 优惠退款信息
    /// </summary>
    public class RefundPromotionDetail : WeChatPayObject
    {
        /// <summary>
        /// 券ID
        /// 券或者立减优惠id。
        /// 示例值：109519
        /// </summary>
        [JsonPropertyName("promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// 优惠范围
        /// GLOBAL：全场代金券
        /// SINGLE：单品优惠
        /// 示例值：SINGLE
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 优惠类型
        /// 枚举值：
        /// COUPON：代金券，需要走结算资金的充值型代金券
        /// DISCOUNT：优惠券，不走结算资金的免充值型优惠券
        /// 示例值：DISCOUNT
        /// </summary>
        [JsonPropertyName("type")]

        public string Type { get; set; }

        /// <summary>
        /// 优惠券面额
        /// 用户享受优惠的金额（优惠券面额=微信出资金额+商家出资金额+其他出资方金额 ），单位为分。
        /// 示例值：5
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 优惠退款金额
        /// 优惠退款金额<=退款金额，退款金额-代金券或立减优惠退款金额为用户支付的现金，说明详见代金券或立减优惠，单位为分。
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public int RefundAmount { get; set; }

        /// <summary>
        /// 商品列表
        /// 优惠商品发生退款时返回商品信息。
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public List<RefundGoodsDetail> GoodsDetail { get; set; }
    }
}
