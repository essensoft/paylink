using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignErrorQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignErrorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_log_list")]
        public List<ErrorLog> ErrorLogList { get; set; }
    }
}
