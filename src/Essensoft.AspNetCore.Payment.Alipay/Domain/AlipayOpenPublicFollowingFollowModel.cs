using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicFollowingFollowModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicFollowingFollowModel : AlipayObject
    {
        /// <summary>
        /// 关注来源ID
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
