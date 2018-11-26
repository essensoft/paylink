using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorCreateModel : AlipayObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [JsonProperty("auth_code")]
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [JsonProperty("department_id")]
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 折让限额单位
        /// </summary>
        [JsonProperty("discount_limit_unit")]
        [XmlElement("discount_limit_unit")]
        public string DiscountLimitUnit { get; set; }

        /// <summary>
        /// 折让限额值
        /// </summary>
        [JsonProperty("discount_limit_value")]
        [XmlElement("discount_limit_value")]
        public string DiscountLimitValue { get; set; }

        /// <summary>
        /// 免单限额单位
        /// </summary>
        [JsonProperty("free_limit_unit")]
        [XmlElement("free_limit_unit")]
        public string FreeLimitUnit { get; set; }

        /// <summary>
        /// 免单限额
        /// </summary>
        [JsonProperty("free_limit_value")]
        [XmlElement("free_limit_value")]
        public string FreeLimitValue { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("gender")]
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 操作员绑定的部门类型 5-部门，6-门店
        /// </summary>
        [JsonProperty("job_type")]
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        [JsonProperty("login_id")]
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 操作员名字
        /// </summary>
        [JsonProperty("operator_name")]
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 角色ID, 示例值角色为店长
        /// </summary>
        [JsonProperty("role_id")]
        [XmlElement("role_id")]
        public string RoleId { get; set; }
    }
}
