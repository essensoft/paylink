using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsReturnOrderItem Data Structure.
    /// </summary>
    public class GoodsReturnOrderItem : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 单价，单位：元，没有设置0
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("qty")]
        public string Qty { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [JsonPropertyName("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [JsonPropertyName("sku_no")]
        public string SkuNo { get; set; }
    }
}
