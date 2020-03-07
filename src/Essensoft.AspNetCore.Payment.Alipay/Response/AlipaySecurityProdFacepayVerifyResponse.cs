using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdFacepayVerifyResponse.
    /// </summary>
    public class AlipaySecurityProdFacepayVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 安全码。当人脸认证成功时，支付宝返回此项参数，商户使用此token发起后续支付流程
        /// </summary>
        [JsonPropertyName("ftoken")]
        public string Ftoken { get; set; }
    }
}
