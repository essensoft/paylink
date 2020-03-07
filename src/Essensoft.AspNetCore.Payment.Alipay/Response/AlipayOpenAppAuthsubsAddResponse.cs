using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAuthsubsAddResponse.
    /// </summary>
    public class AlipayOpenAppAuthsubsAddResponse : AlipayResponse
    {
        /// <summary>
        /// 授权结果唯一标识
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 表明订购失效时间
        /// </summary>
        [JsonPropertyName("invalid_date")]
        public string InvalidDate { get; set; }
    }
}
