using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPayApplepayTransactionauthtokenDeleteResponse.
    /// </summary>
    public class AlipayPayApplepayTransactionauthtokenDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 响应报文头部
        /// </summary>
        [JsonPropertyName("response_header")]
        public BaseOpenApiResponseHeaderDTO ResponseHeader { get; set; }
    }
}
