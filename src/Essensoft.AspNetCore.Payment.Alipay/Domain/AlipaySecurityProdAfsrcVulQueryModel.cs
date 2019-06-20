using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAfsrcVulQueryModel : AlipayObject
    {
        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("vul_id")]
        public long VulId { get; set; }
    }
}
