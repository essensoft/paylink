using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 退款商品
    /// </summary>
    public class RefundGoodsDetail : WeChatPayObject
    {
        /// <summary>
        /// 商户侧商品编码
        /// 由半角的大小写字母、数字、中划线、下划线中的一种或几种组成。
        /// 示例值：1217752501201407033233368018
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
        /// 示例值：iPhone6s 16G
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品单价
        /// 商品单价金额，单位为分
        /// 示例值：528800
        /// </summary>
        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }

        /// <summary>
        /// 商品退款金额
        /// 商品退款金额，单位为分。
        /// 示例值：528800
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public int RefundAmount { get; set; }

        /// <summary>
        /// 商品退货数量
        /// 单品的退款数量，单位为分。
        /// 示例值：1
        /// </summary>
        [JsonPropertyName("refund_quantity")]
        public int RefundQuantity { get; set; }
    }
}
