using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantDepartmentModifyModel Data Structure.
    /// </summary>
    public class KoubeiMerchantDepartmentModifyModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 商户部门id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 商户创建的部门名称，可以修改
        /// </summary>
        [JsonPropertyName("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 人员组织场景，组织部门属性标签，现在支持PROCESSING_ROOM, DELIVER_CENTRE, CENTRAL_KITCHEN三种
        /// </summary>
        [JsonPropertyName("label_code")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 当前部门对应的上级部门id
        /// </summary>
        [JsonPropertyName("parent_dept_id")]
        public string ParentDeptId { get; set; }
    }
}
