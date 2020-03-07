using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantDepartmentShopsQueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantDepartmentShopsQueryModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 判断是否需要加载下属部门的门店列表，当为true是加载当前及其下属部门关联的门店列表，为false时仅加载当前部门id关联的门店列表
        /// </summary>
        [JsonPropertyName("need_sub")]
        public bool NeedSub { get; set; }
    }
}
