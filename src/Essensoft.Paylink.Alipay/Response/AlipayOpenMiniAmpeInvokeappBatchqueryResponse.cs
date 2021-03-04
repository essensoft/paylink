using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
