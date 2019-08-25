using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantDepartmentDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantDepartmentDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 人员管理场景的部门id
        /// </summary>
        [JsonProperty("dept_id")]
        public string DeptId { get; set; }
    }
}
