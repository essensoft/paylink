using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InventoryInfo Data Structure.
    /// </summary>
    public class InventoryInfo : AlipayObject
    {
        /// <summary>
        /// 资产数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 资产类型id编号
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
