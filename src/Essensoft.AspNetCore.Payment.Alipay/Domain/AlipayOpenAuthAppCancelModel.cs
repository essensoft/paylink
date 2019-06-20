using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthAppCancelModel : AlipayObject
    {
        /// <summary>
        /// 授权方应用ID
        /// </summary>
        [JsonProperty("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 授权场景，固定值PLATFORM_APP_AUTH
        /// </summary>
        [JsonProperty("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 当前登录账号支付宝userId
        /// </summary>
        [JsonProperty("operator_user_id")]
        public string OperatorUserId { get; set; }
    }
}
