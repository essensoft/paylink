using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceCompanyQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceCompanyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 企业税务信息
        /// </summary>
        [JsonPropertyName("invoice_company")]
        public InvoiceCompanyInfo InvoiceCompany { get; set; }

        /// <summary>
        /// 支付宝商户ID。当业务前台走支付宝开票系统时，会返回该字段。
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 入驻工单ID
        /// </summary>
        [JsonPropertyName("register_id")]
        public string RegisterId { get; set; }
    }
}
