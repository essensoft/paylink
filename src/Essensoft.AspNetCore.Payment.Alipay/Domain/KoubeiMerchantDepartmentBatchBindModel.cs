using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantDepartmentBatchBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantDepartmentBatchBindModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [JsonProperty("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 部门类型，5为非叶子节点部门即商户创建的部门；6为叶子节点部门即门店，门店在业务上被当成是类型为6的部门
        /// </summary>
        [JsonProperty("dept_type")]
        public string DeptType { get; set; }

        /// <summary>
        /// 操作员基本信息列表
        /// </summary>
        [JsonProperty("operator_list")]
        public List<SimpleOperatorModel> OperatorList { get; set; }
    }
}
