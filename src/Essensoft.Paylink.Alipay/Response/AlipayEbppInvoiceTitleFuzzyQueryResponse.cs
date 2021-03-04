using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
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
