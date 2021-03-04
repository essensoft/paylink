using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 单品列表
    /// </summary>   
    public class GoodsDetail : WeChatPayObject
    {
        /// <summary>
        /// 商户侧商品编码
        /// </summary>
        /// <remarks>
        /// 由半角的大小写字母、数字、中划线、下划线中的一种或几种组成。
        /// <para>示例值：商品编码</para>
        /// </remarks>
        [JsonPropertyName("merchant_goods_id")]
        public string MerchantGoodsId { get; set; }

        /// <summary>
        /// 微信侧商品编码
        /// </summary>
        /// <remarks>
        /// 微信支付定义的统一商品编号（没有可不传）
        /// <para>示例值：1001</para>
        /// </remarks>
        [JsonPropertyName("wechatpay_goods_id")]
        public string WeChatPayGoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <remarks>
        /// 商品的实际名称
        /// <para>示例值：iPhoneX 256G</para>
        /// </remarks>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <remarks>
        /// 用户购买的数量
        /// <para>示例值：1</para>
        /// </remarks>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        /// <remarks>
        /// 商品单价，单位为分
        /// <para>示例值：828800</para>
        /// </remarks>
        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }
    }
}
