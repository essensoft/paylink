using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceAmountLimitDTO Data Structure.
    /// </summary>
    public class InvoiceAmountLimitDTO : AlipayObject
    {
        /// <summary>
        /// 单张发票限额
        /// </summary>
        [JsonPropertyName("amount_limit")]
        public string AmountLimit { get; set; }

        /// <summary>
        /// 发票类型，可选值：电子发票：0，纸质普票：1，纸质专票：2
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public long InvoiceKind { get; set; }

        /// <summary>
        /// 月发票限额
        /// </summary>
        [JsonPropertyName("month_amount_limit")]
        public string MonthAmountLimit { get; set; }
    }
}
