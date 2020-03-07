using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleFuzzyQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleFuzzyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 企业名称列表
        /// </summary>
        [JsonPropertyName("enterprise_name")]
        public List<string> EnterpriseName { get; set; }
    }
}
