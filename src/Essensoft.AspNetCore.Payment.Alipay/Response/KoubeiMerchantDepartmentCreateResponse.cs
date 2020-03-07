using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentCreateResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 员工管理场景商户创建部门成功时返回的部门id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }
    }
}
