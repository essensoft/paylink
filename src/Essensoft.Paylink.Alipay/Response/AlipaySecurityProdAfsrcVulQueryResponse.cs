using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 漏洞信息
        /// </summary>
        [JsonPropertyName("data")]
        public VulInfo Data { get; set; }
    }
}
