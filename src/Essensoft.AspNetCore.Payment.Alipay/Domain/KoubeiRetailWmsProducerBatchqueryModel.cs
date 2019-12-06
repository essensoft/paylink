using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsProducerBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsProducerBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 最多查询100个
        /// </summary>
        [JsonPropertyName("producer_ids")]
        public List<string> ProducerIds { get; set; }
    }
}
