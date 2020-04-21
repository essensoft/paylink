using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentDetailQueryResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 人员管理场景的部门id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 员工管理场景下的商户部门名称，根目录为商户名称，下属部门由商户自己创建，例如可以创建下属部门为“华东大区”
        /// </summary>
        [JsonPropertyName("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 人员组织场景的部门标签码
        /// </summary>
        [JsonPropertyName("label_code")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 当前部门的上级部门id
        /// </summary>
        [JsonPropertyName("parent_dept_id")]
        public string ParentDeptId { get; set; }

        /// <summary>
        /// 部门下包含的门店
        /// </summary>
        [JsonPropertyName("shops")]
        public List<SimpleShopModel> Shops { get; set; }

        /// <summary>
        /// 组织部门类型(5为非叶子部门，6为叶子部门)
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
