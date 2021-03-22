using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwLibraryBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 知识库集合
        /// </summary>
        [JsonPropertyName("libraries")]
        public List<LibraryInfo> Libraries { get; set; }
    }
}
