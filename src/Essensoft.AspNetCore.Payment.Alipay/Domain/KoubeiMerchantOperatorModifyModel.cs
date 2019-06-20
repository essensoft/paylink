using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorModifyModel : AlipayObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 组织部门ID
        /// </summary>
        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 折让限额单位
        /// </summary>
        [JsonProperty("discount_limit_unit")]
        public string DiscountLimitUnit { get; set; }

        /// <summary>
        /// 折让限额值
        /// </summary>
        [JsonProperty("discount_limit_value")]
        public string DiscountLimitValue { get; set; }

        /// <summary>
        /// 每天
        /// </summary>
        [JsonProperty("free_limit_unit")]
        public string FreeLimitUnit { get; set; }

        /// <summary>
        /// 免单限额值
        /// </summary>
        [JsonProperty("free_limit_value")]
        public string FreeLimitValue { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 5-非叶子节点，6叶子节点
        /// </summary>
        [JsonProperty("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 操作员Id
        /// </summary>
        [JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        [JsonProperty("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 操作员角色ID
        /// </summary>
        [JsonProperty("role_id")]
        public string RoleId { get; set; }
    }
}
