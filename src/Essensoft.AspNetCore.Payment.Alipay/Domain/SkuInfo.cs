using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuInfo Data Structure.
    /// </summary>
    public class SkuInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝会员渠道销售的，以分为单位表示的价格，示例中是125.00元
        /// </summary>
        [JsonPropertyName("price_cent")]
        public long PriceCent { get; set; }

        /// <summary>
        /// 商品的划线价，以分为单位，12500表示125元
        /// </summary>
        [JsonPropertyName("reserve_price")]
        public long ReservePrice { get; set; }

        /// <summary>
        /// 商品的skuId
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
