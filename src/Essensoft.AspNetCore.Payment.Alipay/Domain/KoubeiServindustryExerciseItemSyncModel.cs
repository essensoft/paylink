using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseItemSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseItemSyncModel : AlipayObject
    {
        /// <summary>
        /// linux时间戳
        /// </summary>
        [JsonProperty("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 健身项目列表
        /// </summary>
        [JsonProperty("item_list")]
        public List<ExerciseItem> ItemList { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
