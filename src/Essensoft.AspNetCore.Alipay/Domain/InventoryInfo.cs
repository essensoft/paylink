using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// InventoryInfo Data Structure.
    /// </summary>
    public class InventoryInfo : AlipayObject
    {
        /// <summary>
        /// 资产数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 资产类型id编号
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
