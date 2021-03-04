using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceItaskOrderRecordSyncResponse.
    /// </summary>
    public class AlipayIserviceItaskOrderRecordSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonPropertyName("home_api_response")]
        public HomeApiResponse HomeApiResponse { get; set; }
    }
}
