using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BillInvoiceResponseDTO Data Structure.
    /// </summary>
    public class BillInvoiceResponseDTO : AlipayObject
    {
        /// <summary>
        /// 关联的金额1
        /// </summary>
        [JsonPropertyName("bill_relate_amount")]
        public MultiCurrencyMoneyOpenApi BillRelateAmount { get; set; }

        /// <summary>
        /// 发票信息
        /// </summary>
        [JsonPropertyName("invoice")]
        public InvoiceAllResponseDTO Invoice { get; set; }
    }
}
