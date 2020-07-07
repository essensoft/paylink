using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 单品列表信息
    /// </summary>    
    public class PromotionGoodsDetail : WeChatPayObject
    {
        /// <summary>
        /// 商品编码
        /// 商品编码
        /// 示例值：M1006
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

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
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }

        /// <summary>
        /// 商品优惠金额
        /// 商品优惠金额
        /// 示例值：0  
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public int DiscountAmount { get; set; }

        /// <summary>
        /// 商品备注
        /// 商品备注信息
        /// 示例值：商品备注信息
        /// </summary>
        [JsonPropertyName("goods_remark")]
        public string GoodsRemark { get; set; }
    }
}
