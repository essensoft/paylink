using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 漏洞信息列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<VulList> Data { get; set; }
    }
}
