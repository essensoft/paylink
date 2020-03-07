using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPayCodecApplepayCredentialsGetResponse.
    /// </summary>
    public class AlipayPayCodecApplepayCredentialsGetResponse : AlipayResponse
    {
        /// <summary>
        /// 加密后的码列表。 {List of Credential objects}
        /// </summary>
        [JsonPropertyName("credentials")]
        public List<PaymentCredential> Credentials { get; set; }

        /// <summary>
        /// 结果。 statusCode:Status code used to indicate an error. If omitted, assumed to be 200 (success);subStatusCode:Conveys failure codes from downstream entities or for more granular conveyance of specific error conditions;statusMessage:Not parsed programmatically. Example "Downstream system offline".
        /// </summary>
        [JsonPropertyName("response_header")]
        public CredentialsResponseHeader ResponseHeader { get; set; }
    }
}
