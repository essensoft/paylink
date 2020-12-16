using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceResultGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceResultGetResponse : AlipayResponse
    {
        /// <summary>
        /// 发票详细信息 开票返回结果数据列表。 根据platform_tid查询时，可返回多条开票结果数据。 根据apply_id查询时，返回数组中只会有一条数据
        /// </summary>
        [JsonPropertyName("invoice_result_list")]
        public List<AntInvoiceResult> InvoiceResultList { get; set; }
    }
}
