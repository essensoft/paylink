using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectruleQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectruleQueryModel : AlipayObject
    {
        /// <summary>
        /// 企业id-共同账号ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 员工id（可空）
        /// </summary>
        [JsonPropertyName("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 项目id（可空）
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }
    }
}
