using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
