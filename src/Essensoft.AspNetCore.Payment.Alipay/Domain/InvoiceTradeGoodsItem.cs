using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTradeGoodsItem Data Structure.
    /// </summary>
    public class InvoiceTradeGoodsItem : AlipayObject
    {
        /// <summary>
        /// 商品类目
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商户设置的商品编号
        /// </summary>
        [JsonPropertyName("goods_no")]
        public string GoodsNo { get; set; }

        /// <summary>
        /// 商品项支付金额
        /// </summary>
        [JsonPropertyName("goods_sum_amount")]
        public string GoodsSumAmount { get; set; }

        /// <summary>
        /// 商品单价，单位元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 购买商品规格型号描述
        /// </summary>
        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 购买商品单位描述
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
