using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserApplepayOtpresolutionmethodsQueryResponse.
    /// </summary>
    public class AlipayUserApplepayOtpresolutionmethodsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// OpenApi的Otp校验方法负责对象
        /// </summary>
        [JsonPropertyName("resolution_methods")]
        public OpenApiResolutionMethod ResolutionMethods { get; set; }

        /// <summary>
        /// 响应头
        /// </summary>
        [JsonPropertyName("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
