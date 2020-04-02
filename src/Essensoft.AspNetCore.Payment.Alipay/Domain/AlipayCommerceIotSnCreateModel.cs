using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotSnCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotSnCreateModel : AlipayObject
    {
        /// <summary>
        /// 申请单描述信息
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 生成的sn数量
        /// </summary>
        [JsonPropertyName("create_count")]
        public long CreateCount { get; set; }

        /// <summary>
        /// 硬件产品标识位 硬件差异的标识，有硬件换料的需求，需要在SN中区分
        /// </summary>
        [JsonPropertyName("hardware_product_id")]
        public string HardwareProductId { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// pcba板厂商
        /// </summary>
        [JsonPropertyName("pcba")]
        public string Pcba { get; set; }

        /// <summary>
        /// 产品系列
        /// </summary>
        [JsonPropertyName("product_series")]
        public string ProductSeries { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
