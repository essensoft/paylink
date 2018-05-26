using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantDepartmentModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantDepartmentModifyModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonProperty("auth_code")]
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 商户部门id
        /// </summary>
        [JsonProperty("dept_id")]
        [XmlElement("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 商户创建的部门名称，可以修改
        /// </summary>
        [JsonProperty("dept_name")]
        [XmlElement("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 当前部门对应的上级部门id
        /// </summary>
        [JsonProperty("parent_dept_id")]
        [XmlElement("parent_dept_id")]
        public string ParentDeptId { get; set; }
    }
}
