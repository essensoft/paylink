using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeApplepayAuthenticationSubmitResponse.
    /// </summary>
    public class AlipayTradeApplepayAuthenticationSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 核身错误信息
        /// </summary>
        [JsonPropertyName("authentication_error")]
        public string AuthenticationError { get; set; }

        /// <summary>
        /// 失败时的鉴权重试机制
        /// </summary>
        [JsonPropertyName("fallback_authentication_mechanisms")]
        public List<string> FallbackAuthenticationMechanisms { get; set; }

        /// <summary>
        /// applePay公用响应头
        /// </summary>
        [JsonPropertyName("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }

        /// <summary>
        /// 鉴权重试机制
        /// </summary>
        [JsonPropertyName("retry_authentication_mechanisms")]
        public List<string> RetryAuthenticationMechanisms { get; set; }

        /// <summary>
        /// base64之后的证书
        /// </summary>
        [JsonPropertyName("signing_certificate")]
        public string SigningCertificate { get; set; }

        /// <summary>
        /// 最新的鉴权明细信息
        /// </summary>
        [JsonPropertyName("updated_authentication_details")]
        public UpdatedAuthenticationDetails UpdatedAuthenticationDetails { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonPropertyName("updated_transaction_status")]
        public string UpdatedTransactionStatus { get; set; }
    }
}
