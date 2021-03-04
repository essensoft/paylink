using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 单品列表信息
    /// </summary>
    public class PromotionGoodsDetail : WeChatPayObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        /// <remarks>
        /// 商品编码
        /// <para>示例值：M1006</para>
        /// </remarks>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <remarks>
        /// 用户购买的数量
        /// <para>示例值：1</para>
        /// </remarks>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        /// <remarks>
        /// 商品单价，单位为分
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("unit_price")]
        public long? UnitPrice { get; set; }

        /// <summary>
        /// 商品优惠金额
        /// </summary>
        /// <remarks>
        /// 商品优惠金额
        /// <para>示例值：0  </para>
        /// </remarks>
        [JsonPropertyName("discount_amount")]
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// 商品备注
        /// </summary>
        /// <remarks>
        /// 商品备注信息
        /// <para>示例值：商品备注信息</para>
        /// </remarks>
        [JsonPropertyName("goods_remark")]
        public string GoodsRemark { get; set; }
    }
}
