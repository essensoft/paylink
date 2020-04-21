using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniIndividualBusinessCertifyResponse.
    /// </summary>
    public class AlipayOpenMiniIndividualBusinessCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 个体工商户认证结果，true代表认证成功，false代表认证失败
        /// </summary>
        [JsonPropertyName("certify_result")]
        public bool CertifyResult { get; set; }
    }
}
