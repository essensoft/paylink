using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskHufuAuthCreateResponse.
    /// </summary>
    public class AlipaySecurityRiskHufuAuthCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 额外信息
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; set; }

        /// <summary>
        /// 调用应用传入的serial
        /// </summary>
        [JsonPropertyName("serial")]
        public string Serial { get; set; }

        /// <summary>
        /// 虎符创建成功的token，有效时间3分钟
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
