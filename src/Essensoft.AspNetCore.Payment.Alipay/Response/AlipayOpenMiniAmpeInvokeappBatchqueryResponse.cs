using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeInvokeappBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeInvokeappBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 调用应用信息列表
        /// </summary>
        [JsonPropertyName("invoke_app_list")]
        public List<InvokeAppInfo> InvokeAppList { get; set; }
    }
}
