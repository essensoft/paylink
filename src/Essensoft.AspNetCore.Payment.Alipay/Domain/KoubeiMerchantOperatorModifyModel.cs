using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorModifyModel Data Structure.
    /// </summary>
    public class KoubeiMerchantOperatorModifyModel : AlipayObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 组织部门ID
        /// </summary>
        [JsonPropertyName("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 折让限额单位
        /// </summary>
        [JsonPropertyName("discount_limit_unit")]
        public string DiscountLimitUnit { get; set; }

        /// <summary>
        /// 折让限额值
        /// </summary>
        [JsonPropertyName("discount_limit_value")]
        public string DiscountLimitValue { get; set; }

        /// <summary>
        /// 每天
        /// </summary>
        [JsonPropertyName("free_limit_unit")]
        public string FreeLimitUnit { get; set; }

        /// <summary>
        /// 免单限额值
        /// </summary>
        [JsonPropertyName("free_limit_value")]
        public string FreeLimitValue { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 5-非叶子节点，6叶子节点
        /// </summary>
        [JsonPropertyName("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 操作员Id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        [JsonPropertyName("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 操作员角色ID
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }
    }
}
