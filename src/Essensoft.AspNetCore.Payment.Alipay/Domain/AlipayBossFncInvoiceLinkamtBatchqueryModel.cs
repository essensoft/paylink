using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceLinkamtBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncInvoiceLinkamtBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 发票ID，唯一性ID，发票表唯一主键ID
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
