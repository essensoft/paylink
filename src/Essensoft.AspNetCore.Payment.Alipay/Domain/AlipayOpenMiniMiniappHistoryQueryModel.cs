using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappHistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappHistoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 管控的令牌
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 请求的列表长度
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
