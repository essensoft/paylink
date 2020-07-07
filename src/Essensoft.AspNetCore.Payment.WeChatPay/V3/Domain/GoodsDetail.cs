using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 单品列表
    /// </summary>   
    public class GoodsDetail : WeChatPayObject
    {
        /// <summary>
        /// 商户侧商品编码
        /// 由半角的大小写字母、数字、中划线、下划线中的一种或几种组成。
        /// 示例值：商品编码
        /// </summary>
        [JsonPropertyName("merchant_goods_id")]
        public string MerchantGoodsId { get; set; }

        /// <summary>
        /// 微信侧商品编码
        /// 微信支付定义的统一商品编号（没有可不传）
        /// 示例值：1001
        /// </summary>
        [JsonPropertyName("wechatpay_goods_id")]
        public string WeChatPayGoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// 商品的实际名称
        /// 示例值：iPhoneX 256G
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品数量
        /// 用户购买的数量
        /// 示例值：1
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 商品单价
        /// 商品单价，单位为分
        /// 示例值：828800
        /// </summary>
        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }
    }
}
