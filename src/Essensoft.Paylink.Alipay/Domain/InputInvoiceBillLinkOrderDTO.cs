using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InputInvoiceBillLinkOrderDTO Data Structure.
    /// </summary>
    public class InputInvoiceBillLinkOrderDTO : AlipayObject
    {
        /// <summary>
        /// 账单号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 关联金额
        /// </summary>
        [JsonPropertyName("relate_amount")]
        public MultiCurrencyMoneyOpenApi RelateAmount { get; set; }

        /// <summary>
        /// 关联到账单上的税额
        /// </summary>
        [JsonPropertyName("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }
    }
}
