using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdCreativeOfflineModel : AlipayObject
    {
        /// <summary>
        /// 广告主id  + 下线创意时，需要校验该创意是否属于该用户
        /// </summary>
        [JsonProperty("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 创意id + 根据创意id操作对应的创意下线
        /// </summary>
        [JsonProperty("creative_id")]
        public long CreativeId { get; set; }
    }
}
