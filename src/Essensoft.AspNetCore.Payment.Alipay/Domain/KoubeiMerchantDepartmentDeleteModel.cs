using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantDepartmentDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantDepartmentDeleteModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 需要被删除的部门id
        /// </summary>
        [JsonProperty("dept_id")]
        public string DeptId { get; set; }
    }
}
