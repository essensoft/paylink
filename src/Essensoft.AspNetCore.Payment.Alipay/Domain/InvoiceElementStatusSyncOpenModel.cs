using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceElementStatusSyncOpenModel Data Structure.
    /// </summary>
    public class InvoiceElementStatusSyncOpenModel : AlipayObject
    {
        /// <summary>
        /// 同步申请id，每次发起同步时生成，isv每次请求需要保证唯一
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 报销详情地址，提供用户通过发票管家查看报销进度的地址  如果报销企业入驻发票管家时需要isv传入报销详情地址，则必须提供
        /// </summary>
        [JsonPropertyName("expense_detail_url")]
        public string ExpenseDetailUrl { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }
    }
}
