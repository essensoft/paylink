using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceListExpenseSyncModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceListExpenseSyncModel : AlipayObject
    {
        /// <summary>
        /// 报销进度变更时间
        /// </summary>
        [JsonPropertyName("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 商户报销单据号
        /// </summary>
        [JsonPropertyName("expense_order_no")]
        public string ExpenseOrderNo { get; set; }

        /// <summary>
        /// 报销企业税号
        /// </summary>
        [JsonPropertyName("expense_tax_no")]
        public string ExpenseTaxNo { get; set; }

        /// <summary>
        /// 需要同步报销状态的发票列表
        /// </summary>
        [JsonPropertyName("invoice_element_list")]
        public List<InvoiceElementStatusSyncOpenModel> InvoiceElementList { get; set; }

        /// <summary>
        /// 报销审批备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// EXPENSE_APPLY:报销申请提交;EXPENSE_APPROVAL_PASS:报销申请审核通过;EXPENSE_FINISHED:报销申请完成;EXPENSE_CANCEL:报销申请撤回
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
