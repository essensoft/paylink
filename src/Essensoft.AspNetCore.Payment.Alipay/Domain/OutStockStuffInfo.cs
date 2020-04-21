using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OutStockStuffInfo Data Structure.
    /// </summary>
    public class OutStockStuffInfo : AlipayObject
    {
        /// <summary>
        /// 实出库数量
        /// </summary>
        [JsonPropertyName("actual_qty")]
        public long ActualQty { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 物料sku
        /// </summary>
        [JsonPropertyName("sku_no")]
        public string SkuNo { get; set; }
    }
}
