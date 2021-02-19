using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
