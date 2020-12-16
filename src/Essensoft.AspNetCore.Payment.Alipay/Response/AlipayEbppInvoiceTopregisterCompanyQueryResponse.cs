using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterCompanyQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTopregisterCompanyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 企业税务信息查询输出
        /// </summary>
        [JsonPropertyName("result")]
        public InvoiceCompanyQueryResult Result { get; set; }
    }
}
