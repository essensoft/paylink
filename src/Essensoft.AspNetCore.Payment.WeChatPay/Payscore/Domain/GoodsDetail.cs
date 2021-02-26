using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    /// 单品信息
    /// </summary>
    public class GoodsDetail
    {
        /// <summary>
        /// 商品编码
        /// 示例值：M1006
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品数量
        /// 示例值：1
        /// </summary>
        [JsonPropertyName("quantity")]
        public uint Quantity { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [JsonPropertyName("unit_price")]
        public long UnitPrice { get; set; }

        /// <summary>
        /// 商品优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// 商品备注
        /// </summary>
        [JsonPropertyName("goods_remark")]
        public string GoodsRemark { get; set; }
    }
}
