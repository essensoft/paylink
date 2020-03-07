using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcWhitehatinfoQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcWhitehatinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 白帽子信息
        /// </summary>
        [JsonPropertyName("data")]
        public WhitehatInfo Data { get; set; }
    }
}
