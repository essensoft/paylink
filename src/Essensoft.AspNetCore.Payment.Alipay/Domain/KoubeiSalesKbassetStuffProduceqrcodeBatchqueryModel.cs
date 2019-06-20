using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffProduceqrcodeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffProduceqrcodeBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 每页容量，最小1，最大100
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 生产单号
        /// </summary>
        [JsonProperty("produce_order_id")]
        public string ProduceOrderId { get; set; }
    }
}
