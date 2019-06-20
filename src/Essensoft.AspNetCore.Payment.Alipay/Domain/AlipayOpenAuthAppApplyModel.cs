using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthAppApplyModel : AlipayObject
    {
        /// <summary>
        /// 授权方应用在蚂蚁开放平台的应用ID
        /// </summary>
        [JsonProperty("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 授权场景，固定值PLATFORM_APP_AUTH
        /// </summary>
        [JsonProperty("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 当前登录账号的支付宝userId
        /// </summary>
        [JsonProperty("operator_user_id")]
        public string OperatorUserId { get; set; }
    }
}
