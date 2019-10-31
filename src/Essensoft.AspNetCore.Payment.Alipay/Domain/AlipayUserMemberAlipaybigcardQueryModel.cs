using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserMemberAlipaybigcardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberAlipaybigcardQueryModel : AlipayObject
    {
        /// <summary>
        /// 缓存是否可用，手淘在请求前先查uid的缓存，新用户请求未落缓存或者上次缓存已经被清空时为false
        /// </summary>
        [JsonProperty("available_cache")]
        public bool AvailableCache { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，根据uid判别展示权益内容。由手淘直接传给支付宝
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
