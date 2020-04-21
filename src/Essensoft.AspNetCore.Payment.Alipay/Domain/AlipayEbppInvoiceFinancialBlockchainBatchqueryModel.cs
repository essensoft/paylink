using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceFinancialBlockchainBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceFinancialBlockchainBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 证件号码的hash值，使用MD5算法获取的hash
        /// </summary>
        [JsonPropertyName("cert_no_hash")]
        public string CertNoHash { get; set; }

        /// <summary>
        /// 证件类型  可选值（身份证：IDENTITY_CARD）
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 当前页码，起始号码是1
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 票据种类  可选值（财政电子票据：FINANCIAL_ELECTRONIC_BILL）
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 分页大小，最大值为50
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
