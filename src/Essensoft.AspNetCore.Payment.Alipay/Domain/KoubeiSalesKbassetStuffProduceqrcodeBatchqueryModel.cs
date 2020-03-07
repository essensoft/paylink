using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffProduceqrcodeBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffProduceqrcodeBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑批次号
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 每页容量，最小1，最大100
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 生产单号
        /// </summary>
        [JsonPropertyName("produce_order_id")]
        public string ProduceOrderId { get; set; }
    }
}
