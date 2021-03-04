using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMemberDataDesdBatchqueryResponse.
    /// </summary>
    public class KoubeiMemberDataDesdBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("de")]
        public GavintestNewonline De { get; set; }
    }
}
