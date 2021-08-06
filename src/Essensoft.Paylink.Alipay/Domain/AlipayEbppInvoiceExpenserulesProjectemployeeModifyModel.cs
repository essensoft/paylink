using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectemployeeModifyModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectemployeeModifyModel : AlipayObject
    {
        /// <summary>
        /// 企业id-共同账号ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 需要添加的员工支付宝id列表（一次最多50个，同时删除同一个ID则不生效）
        /// </summary>
        [JsonPropertyName("add_employee_list")]
        public List<string> AddEmployeeList { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 需要移除的员工支付宝id列表（一次最多50个，同时新增同一个ID则不生效）
        /// </summary>
        [JsonPropertyName("remove_employee_list")]
        public List<string> RemoveEmployeeList { get; set; }
    }
}
