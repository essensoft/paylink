using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserApplepayOtpSendResponse.
    /// </summary>
    public class AlipayUserApplepayOtpSendResponse : AlipayResponse
    {
        /// <summary>
        /// 响应头
        /// </summary>
        [JsonPropertyName("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
