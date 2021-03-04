using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
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
