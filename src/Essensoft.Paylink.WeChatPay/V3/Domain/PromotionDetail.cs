using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 优惠功能
    /// </summary>
    public class PromotionDetail : WeChatPayObject
    {
        /// <summary>
        /// 券ID
        /// </summary>
        /// <remarks>
        /// 券ID
        /// <para>示例值：109519</para>
        /// </remarks>
        [JsonPropertyName("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        /// <remarks>
        /// 优惠名称
        /// <para>示例值：单品惠-6</para>
        /// </remarks>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠范围
        /// </summary>
        /// <remarks>
        /// GLOBAL：全场代金券
        /// SINGLE：单品优惠
        /// <para>示例值：GLOBAL</para>
        /// </remarks>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        /// <remarks>
        /// CASH：充值
        /// NOCASH：预充值
        /// <para>示例值：CASH</para>
        /// </remarks>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 优惠券面额
        /// </summary>
        /// <remarks>
        /// 优惠券面额
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        /// <remarks>
        /// 活动ID
        /// <para>示例值：931386</para>
        /// </remarks>
        [JsonPropertyName("stock_id")]
        public string StockId { get; set; }

        /// <summary>
        /// 微信出资
        /// </summary>
        /// <remarks>
        /// 微信出资，单位为分
        /// <para>示例值：0</para>
        /// </remarks>
        [JsonPropertyName("wechatpay_contribute")]
        public int? WeChatPayContribute { get; set; }

        /// <summary>
        /// 商户出资
        /// </summary>
        /// <remarks>
        /// 商户出资，单位为分
        /// <para>示例值：0</para>
        /// </remarks>
        [JsonPropertyName("merchant_contribute")]
        public long? MerchantContribute { get; set; }

        /// <summary>
        /// 其他出资
        /// </summary>
        /// <remarks>
        /// 其他出资，单位为分
        /// <para>示例值：0</para>
        /// </remarks>
        [JsonPropertyName("other_contribute")]
        public long? OtherContribute { get; set; }

        /// <summary>
        /// 优惠币种
        /// </summary>
        /// <remarks>
        /// CNY：人民币，境内商户号仅支持人民币。
        /// <para>示例值：CNY</para>
        /// </remarks>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 单品列表
        /// 单品列表信息
        /// </summary>
        /// <remarks>
        /// 单品列表信息
        /// </remarks>
        [JsonPropertyName("goods_detail")]
        public List<PromotionGoodsDetail> GoodsDetail { get; set; }
    }
}
