using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseQuestInstancesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseQuestInstancesQueryModel : AlipayObject
    {
        /// <summary>
        /// 目标ID列表，列表长度不能超过20
        /// </summary>
        [JsonProperty("quest_ids")]
        public List<string> QuestIds { get; set; }

        /// <summary>
        /// 调用方标识
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
