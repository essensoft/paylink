using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InviteMemberBusinessParamsDTO Data Structure.
    /// </summary>
    public class InviteMemberBusinessParamsDTO : AlipayObject
    {
        /// <summary>
        /// 企业员工工卡
        /// </summary>
        [JsonPropertyName("employee_id")]
        public string EmployeeId { get; set; }
    }
}
