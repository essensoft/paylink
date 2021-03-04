using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniReleaststBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniReleaststBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("des")]
        public GavintestNewLeveaOne Des { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [JsonPropertyName("out")]
        public string Out { get; set; }
    }
}
