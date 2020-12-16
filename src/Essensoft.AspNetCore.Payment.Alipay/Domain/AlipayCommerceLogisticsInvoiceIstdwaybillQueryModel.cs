using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsInvoiceIstdwaybillQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsInvoiceIstdwaybillQueryModel : AlipayObject
    {
        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 开票请求流水号
        /// </summary>
        [JsonPropertyName("out_invoice_request_no")]
        public string OutInvoiceRequestNo { get; set; }
    }
}
