using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniReleaststBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniReleaststBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonProperty("des")]
        public GavintestNewLeveaOne Des { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [JsonProperty("out")]
        public string Out { get; set; }
    }
}
