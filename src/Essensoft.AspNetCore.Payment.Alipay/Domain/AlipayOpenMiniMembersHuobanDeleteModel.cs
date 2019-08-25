using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMembersHuobanDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMembersHuobanDeleteModel : AlipayObject
    {
        /// <summary>
        /// 用户域账号
        /// </summary>
        [JsonProperty("domain_account")]
        public string DomainAccount { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [JsonProperty("login_id")]
        public string LoginId { get; set; }

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
