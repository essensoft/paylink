using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotSnApplyBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotSnApplyBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 每页数量，最多100
        /// </summary>
        [JsonPropertyName("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 分页搜索偏移值
        /// </summary>
        [JsonPropertyName("offset")]
        public long Offset { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
