using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ExpenseCtrlConsumeInfo Data Structure.
    /// </summary>
    public class ExpenseCtrlConsumeInfo : AlipayObject
    {
        /// <summary>
        /// 账单基本信息
        /// </summary>
        [JsonPropertyName("expense_consume_info")]
        public ExpenseConsumeInfo ExpenseConsumeInfo { get; set; }

        /// <summary>
        /// 关联凑票账单列表（开票限额，多次消费后合并开票）
        /// </summary>
        [JsonPropertyName("related_enterprise_consume_list")]
        public List<ExpenseConsumeInfo> RelatedEnterpriseConsumeList { get; set; }

        /// <summary>
        /// 关联发票凭证对象
        /// </summary>
        [JsonPropertyName("related_enterprise_invoice_list")]
        public List<ExpenseInvoiceInfo> RelatedEnterpriseInvoiceList { get; set; }
    }
}
