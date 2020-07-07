using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 优惠功能
    /// </summary>
    public class PromotionDetail : WeChatPayObject
    {
        /// <summary>
        /// 券ID
        /// 券ID
        /// 示例值：109519
        /// </summary>
        [JsonPropertyName("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 优惠名称
        /// 优惠名称
        /// 示例值：单品惠-6
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠范围
        /// GLOBAL：全场代金券
        /// SINGLE：单品优惠
        /// 示例值：GLOBAL
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 优惠类型
        /// CASH：充值
        /// NOCASH：预充值
        /// 示例值：CASH
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 优惠券面额
        /// 优惠券面额
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 活动ID
        /// 活动ID
        /// 示例值：931386
        /// </summary>
        [JsonPropertyName("stock_id")]
        public string StockId { get; set; }

        /// <summary>
        /// 微信出资
        /// 微信出资，单位为分
        /// 示例值：0
        /// </summary>
        [JsonPropertyName("wechatpay_contribute")]
        public int WeChatPayContribute { get; set; }

        /// <summary>
        /// 商户出资	
        /// 商户出资，单位为分
        /// 示例值：0
        /// </summary>
        [JsonPropertyName("merchant_contribute")]
        public int MerchantContribute { get; set; }

        /// <summary>
        /// 其他出资
        /// 其他出资，单位为分
        /// 示例值：0
        /// </summary>
        [JsonPropertyName("other_contribute")]
        public int OtherContribute { get; set; }

        /// <summary>
        /// 优惠币种
        /// CNY：人民币，境内商户号仅支持人民币。
        /// 示例值：CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 单品列表
        /// 单品列表信息
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public List<PromotionGoodsDetail> goods_detail { get; set; }
    }
}
