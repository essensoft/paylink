using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceAmountLimitInfo Data Structure.
    /// </summary>
    public class InvoiceAmountLimitInfo : AlipayObject
    {
        /// <summary>
        /// 单张发票限额，单位元
        /// </summary>
        [JsonPropertyName("amount_limit")]
        public string AmountLimit { get; set; }

        /// <summary>
        /// 税号可开发票类型，列表类型。 可选值： 增值税电子普通发票：PLAIN, 增值税专用发票：SPECIAL， 增值税普通发票：PLAIN_INVOICE，增值税普通发票(卷式)：PAPER_INVOICE
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 月发票限额，单位元
        /// </summary>
        [JsonPropertyName("month_amount_limit")]
        public string MonthAmountLimit { get; set; }
    }
}
