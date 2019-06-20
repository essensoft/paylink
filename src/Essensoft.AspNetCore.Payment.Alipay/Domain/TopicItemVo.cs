using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TopicItemVo Data Structure.
    /// </summary>
    [Serializable]
    public class TopicItemVo : AlipayObject
    {
        /// <summary>
        /// 话题描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 话题ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 0 正常状态，可使用;   -1 下线，不可使用。
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 话题标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
