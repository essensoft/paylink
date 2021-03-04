using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleBatchqueryInnerResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleBatchqueryInnerResponse : AlipayResponse
    {
        /// <summary>
        /// 用户抬头列表（包括个人、单位抬头）
        /// </summary>
        [JsonPropertyName("title_list")]
        public List<InvoiceTitleModel> TitleList { get; set; }
    }
}
