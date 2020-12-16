using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceFileOutputQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceFileOutputQueryModel : AlipayObject
    {
        /// <summary>
        /// 发票代码  字段长度（10-12位）
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码  字段长度（8-10位）
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票pdf文件下载应用场景  固定值－INVOICE_EXPENSE
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步
        /// </summary>
        [JsonPropertyName("skip_expense_progress_sync")]
        public bool SkipExpenseProgressSync { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
