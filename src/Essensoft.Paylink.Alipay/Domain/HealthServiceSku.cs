using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HealthServiceSku Data Structure.
    /// </summary>
    public class HealthServiceSku : AlipayObject
    {
        /// <summary>
        /// 商家sku条形码
        /// </summary>
        [JsonPropertyName("merchant_item_sku_bar_code")]
        public string MerchantItemSkuBarCode { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
