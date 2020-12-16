using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
