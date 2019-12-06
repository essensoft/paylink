using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseItemSyncModel Data Structure.
    /// </summary>
    public class KoubeiServindustryExerciseItemSyncModel : AlipayObject
    {
        /// <summary>
        /// linux时间戳
        /// </summary>
        [JsonPropertyName("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 健身项目列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<ExerciseItem> ItemList { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
