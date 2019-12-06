using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTrustUserAuthSendResponse.
    /// </summary>
    public class AlipayTrustUserAuthSendResponse : AlipayResponse
    {
        /// <summary>
        /// 当授权通知发送成功时，为T；否则用业务错误码表示
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
