using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskReconfirmVerificatecallbackSendResponse.
    /// </summary>
    public class AlipaySecurityRiskReconfirmVerificatecallbackSendResponse : AlipayResponse
    {
        /// <summary>
        /// 额外返回信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }
    }
}
