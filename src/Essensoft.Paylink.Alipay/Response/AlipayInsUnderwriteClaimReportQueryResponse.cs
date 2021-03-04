using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsUnderwriteClaimReportQueryResponse.
    /// </summary>
    public class AlipayInsUnderwriteClaimReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 案件信息
        /// </summary>
        [JsonPropertyName("reports")]
        public List<InsClaimReport> Reports { get; set; }
    }
}
