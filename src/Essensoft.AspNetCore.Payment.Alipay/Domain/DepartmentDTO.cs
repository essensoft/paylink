using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DepartmentDTO Data Structure.
    /// </summary>
    public class DepartmentDTO : AlipayObject
    {
        /// <summary>
        /// 业务类型KOUBEI_OPERATOR
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 部门组织id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 组织树部门名称
        /// </summary>
        [JsonPropertyName("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 组织部门树
        /// </summary>
        [JsonPropertyName("dept_path")]
        public string DeptPath { get; set; }

        /// <summary>
        /// 人员组织场景的部门标签码
        /// </summary>
        [JsonPropertyName("label_code")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 人员组织场景的部门标签名称
        /// </summary>
        [JsonPropertyName("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 上级组织部门id
        /// </summary>
        [JsonPropertyName("parent_dept_id")]
        public string ParentDeptId { get; set; }

        /// <summary>
        /// 门店id，只有叶子节点部门才有shop_id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 组织部门类型(5为非叶子部门，6为叶子部门)
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
