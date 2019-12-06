using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StuffStockInOrderItem Data Structure.
    /// </summary>
    public class StuffStockInOrderItem : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 入库单物料数量
        /// </summary>
        [JsonPropertyName("qty")]
        public long Qty { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [JsonPropertyName("sku_no")]
        public string SkuNo { get; set; }
    }
}
