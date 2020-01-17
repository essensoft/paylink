using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FinanceInvoiceInfo Data Structure.
    /// </summary>
    public class FinanceInvoiceInfo : AlipayObject
    {
        /// <summary>
        /// 发票金额，以元为单位的，精确到小数点后2位
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// UTC标准格式
        /// </summary>
        [JsonPropertyName("billing_date")]
        public string BillingDate { get; set; }

        /// <summary>
        /// 发票验证码后6位
        /// </summary>
        [JsonPropertyName("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 发票影印件信息
        /// </summary>
        [JsonPropertyName("file")]
        public FinanceFileInfo File { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber { get; set; }
    }
}
