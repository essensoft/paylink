using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMembersHuobanModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMembersHuobanModifyModel : AlipayObject
    {
        /// <summary>
        /// 域账号
        /// </summary>
        [JsonPropertyName("domain_account")]
        public string DomainAccount { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 修改前的支付宝账号
        /// </summary>
        [JsonPropertyName("old_login_id")]
        public string OldLoginId { get; set; }

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
