using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InStockStuffInfo Data Structure.
    /// </summary>
    public class InStockStuffInfo : AlipayObject
    {
        /// <summary>
        /// 实收数量
        /// </summary>
        [JsonPropertyName("actual_qty")]
        public string ActualQty { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 计划数量
        /// </summary>
        [JsonPropertyName("plan_qty")]
        public long PlanQty { get; set; }

        /// <summary>
        /// 物料sku
        /// </summary>
        [JsonPropertyName("sku_no")]
        public string SkuNo { get; set; }
    }
}
