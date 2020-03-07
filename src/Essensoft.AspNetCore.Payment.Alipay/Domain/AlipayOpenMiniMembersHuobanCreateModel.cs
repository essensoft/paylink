using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMembersHuobanCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMembersHuobanCreateModel : AlipayObject
    {
        /// <summary>
        /// 内部员工域账号
        /// </summary>
        [JsonPropertyName("domain_account")]
        public string DomainAccount { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("operate_app_id")]
        public string OperateAppId { get; set; }

        /// <summary>
        /// 成员角色
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
