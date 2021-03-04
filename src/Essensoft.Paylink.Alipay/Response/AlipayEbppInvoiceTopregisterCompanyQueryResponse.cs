using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
