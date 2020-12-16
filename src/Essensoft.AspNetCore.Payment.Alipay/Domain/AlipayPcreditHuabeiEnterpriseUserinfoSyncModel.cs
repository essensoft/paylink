using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiEnterpriseUserinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiEnterpriseUserinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 商务花呗用户协议id
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 员工在支付宝的用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 员工所在部门名称
        /// </summary>
        [JsonPropertyName("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 员工所在公司总人数
        /// </summary>
        [JsonPropertyName("employee_count")]
        public string EmployeeCount { get; set; }

        /// <summary>
        /// 员工职级
        /// </summary>
        [JsonPropertyName("employee_level")]
        public string EmployeeLevel { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [JsonPropertyName("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工岗位
        /// </summary>
        [JsonPropertyName("employee_position")]
        public string EmployeePosition { get; set; }

        /// <summary>
        /// 员工入职时间，精确到月份，yyyymm六位
        /// </summary>
        [JsonPropertyName("entry_time")]
        public string EntryTime { get; set; }

        /// <summary>
        /// 员工身份证号（和员工手机号至少填写一个）
        /// </summary>
        [JsonPropertyName("identity_no")]
        public string IdentityNo { get; set; }

        /// <summary>
        /// 员工邮箱
        /// </summary>
        [JsonPropertyName("mail_addr")]
        public string MailAddr { get; set; }

        /// <summary>
        /// 员工是否管理岗，是管理岗传Y，非管理岗传N
        /// </summary>
        [JsonPropertyName("management")]
        public string Management { get; set; }

        /// <summary>
        /// 员工手机号（和员工身份证号至少填写一个）
        /// </summary>
        [JsonPropertyName("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 企业对应的支付宝商户Pid
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
