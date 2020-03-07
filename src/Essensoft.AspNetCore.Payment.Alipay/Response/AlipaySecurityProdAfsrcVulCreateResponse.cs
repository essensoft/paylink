using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulCreateResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 漏洞创建结果描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 漏洞创建是否成功标识
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
