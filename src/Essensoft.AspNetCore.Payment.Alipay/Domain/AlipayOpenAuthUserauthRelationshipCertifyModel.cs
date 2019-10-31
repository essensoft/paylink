using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationshipCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthUserauthRelationshipCertifyModel : AlipayObject
    {
        /// <summary>
        /// 操作接口名字
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
