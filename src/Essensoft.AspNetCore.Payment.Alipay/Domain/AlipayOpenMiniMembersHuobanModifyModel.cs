using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMembersHuobanModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMembersHuobanModifyModel : AlipayObject
    {
        /// <summary>
        /// 域账号
        /// </summary>
        [JsonProperty("domain_account")]
        public string DomainAccount { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [JsonProperty("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 修改前的支付宝账号
        /// </summary>
        [JsonProperty("old_login_id")]
        public string OldLoginId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("operate_app_id")]
        public string OperateAppId { get; set; }

        /// <summary>
        /// 成员角色
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
