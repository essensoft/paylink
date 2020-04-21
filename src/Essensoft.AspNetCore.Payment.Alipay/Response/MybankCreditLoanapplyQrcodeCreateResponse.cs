using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeCreateResponse.
    /// </summary>
    public class MybankCreditLoanapplyQrcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 生成二维码的加密 token 字符串
        /// </summary>
        [JsonPropertyName("encrypt_token")]
        public string EncryptToken { get; set; }

        /// <summary>
        /// 生成的二维码的链接地址，拿这个地址生成二维码
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
