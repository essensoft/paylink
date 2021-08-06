using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesGroupemployeeModifyModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesGroupemployeeModifyModel : AlipayObject
    {
        /// <summary>
        /// 企业id-共同账号ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 需要添加的员工Uid列表（一次最多50个）
        /// </summary>
        [JsonPropertyName("add_employee_list")]
        public List<string> AddEmployeeList { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 费控规则ID（可以线下获取，也可以通过接口添加创建）
        /// </summary>
        [JsonPropertyName("group_id_list")]
        public List<string> GroupIdList { get; set; }

        /// <summary>
        /// 需要移除的员工Uid列表（一次最多50个）
        /// </summary>
        [JsonPropertyName("remove_employee_list")]
        public List<string> RemoveEmployeeList { get; set; }
    }
}
