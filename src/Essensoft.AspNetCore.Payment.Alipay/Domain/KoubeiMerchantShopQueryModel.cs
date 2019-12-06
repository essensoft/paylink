using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantShopQueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantShopQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户从口碑商家中心页面跳转到ISV页面时url中带有的authCode值,用来ISV获取用户身份。
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 商户的部门id，如果有值，返回当前商户下的所有未分配过部门的门店，加上当前部门id及其下分支部门的门店一起返回。如果为空，则仅返回当前商户下的所有未分配过部门的门店。
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }
    }
}
