using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitlelibraryListQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitlelibraryListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 抬头名称列表
        /// </summary>
        [JsonPropertyName("title_name_list")]
        public List<string> TitleNameList { get; set; }
    }
}
