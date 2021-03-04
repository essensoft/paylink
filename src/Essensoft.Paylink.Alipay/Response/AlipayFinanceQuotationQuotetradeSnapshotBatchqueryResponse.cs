using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSnapshotBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSnapshotBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 快照对象
        /// </summary>
        [JsonPropertyName("data")]
        public List<SnapshotDTO> Data { get; set; }
    }
}
