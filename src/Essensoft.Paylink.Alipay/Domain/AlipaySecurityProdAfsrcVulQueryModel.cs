using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulQueryModel : AlipayObject
    {
        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonPropertyName("vul_id")]
        public long VulId { get; set; }
    }
}
