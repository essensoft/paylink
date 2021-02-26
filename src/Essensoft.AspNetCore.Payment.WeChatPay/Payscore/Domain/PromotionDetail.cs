using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    /// 优惠功能
    /// </summary>
    public class PromotionDetail
    {
        /// <summary>
        /// 券ID
        /// 示例值：123456
        /// </summary>
        [JsonPropertyName("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 优惠名称
        /// 示例值：单品优惠-6
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠范围
        /// </summary>
        /// <remarks>
        /// GLOBAL：全场代金券；
        /// SINGLE：单品优惠
        /// 示例值：GLOBAL
        /// </remarks>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        /// <remarks>
        /// 枚举值：CASH：充值；
        /// NOCASH：免充值。
        /// 示例值：CASH
        /// </remarks>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 优惠券面额
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        /// <remarks>
        /// 活动ID，批次ID
        /// 示例值：activity_id
        /// </remarks>
        [JsonPropertyName("stock_id")]
        public string StockId { get; set; }

        /// <summary>
        /// 微信出资
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("wechatpay_contribute")]
        public long WechatpayContribute { get; set; }

        /// <summary>
        /// 商户出资
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("merchant_contribute")]
        public long MerchantContribute { get; set; }

        /// <summary>
        /// 其他出资
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("other_contribute")]
        public long OtherContribute { get; set; }

        /// <summary>
        /// 优惠币种
        /// </summary>
        /// <remarks>
        /// CNY：人民币，境内商户号仅支持人民币
        /// 示例值：CNY
        /// </remarks>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 单品列表
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public List<GoodsDetail> GoodsDetails { get; set; }
    }
}
