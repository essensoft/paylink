using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
