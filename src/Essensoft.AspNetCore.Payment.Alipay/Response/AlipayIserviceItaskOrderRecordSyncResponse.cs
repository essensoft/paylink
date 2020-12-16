using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
