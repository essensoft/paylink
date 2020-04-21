using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorDetailsQueryResponse.
    /// </summary>
    public class KoubeiMerchantOperatorDetailsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 操作员所属的部门id
        /// </summary>
        [JsonPropertyName("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 操作员所属的组织部门名称
        /// </summary>
        [JsonPropertyName("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 折让限额单位长度不合法
        /// </summary>
        [JsonPropertyName("discount_limit_unit")]
        public string DiscountLimitUnit { get; set; }

        /// <summary>
        /// 折让限额
        /// </summary>
        [JsonPropertyName("discount_limit_value")]
        public string DiscountLimitValue { get; set; }

        /// <summary>
        /// 30
        /// </summary>
        [JsonPropertyName("free_limit_unit")]
        public string FreeLimitUnit { get; set; }

        /// <summary>
        /// 免单限额
        /// </summary>
        [JsonPropertyName("free_limit_value")]
        public string FreeLimitValue { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 操作员关联的部门类型  5-部门  6-门店
        /// </summary>
        [JsonPropertyName("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 操作员登录账号
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 管理的门店数量
        /// </summary>
        [JsonPropertyName("manage_shops")]
        public string ManageShops { get; set; }

        /// <summary>
        /// 操作员绑定的手机号，会用于接收短信校验码和短信通知
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员真实姓名
        /// </summary>
        [JsonPropertyName("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 操作员激活码
        /// </summary>
        [JsonPropertyName("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 角色代码
        /// </summary>
        [JsonPropertyName("role_code")]
        public string RoleCode { get; set; }

        /// <summary>
        /// 操作员关联的角色id
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 操作员关联的角色名称
        /// </summary>
        [JsonPropertyName("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// 操作员状态： 未激活-W，锁定-U，正常-T
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
