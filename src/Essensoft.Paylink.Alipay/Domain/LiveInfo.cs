using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// LiveInfo Data Structure.
    /// </summary>
    public class LiveInfo : AlipayObject
    {
        /// <summary>
        /// 直播内容信息列表
        /// </summary>
        [JsonPropertyName("content_info_list")]
        public List<LiveContentInfo> ContentInfoList { get; set; }

        /// <summary>
        /// 直播结束时间
        /// </summary>
        [JsonPropertyName("live_end_time")]
        public string LiveEndTime { get; set; }

        /// <summary>
        /// 直播ID
        /// </summary>
        [JsonPropertyName("live_id")]
        public string LiveId { get; set; }

        /// <summary>
        /// 直播开始时间
        /// </summary>
        [JsonPropertyName("live_start_time")]
        public string LiveStartTime { get; set; }

        /// <summary>
        /// 直播摘要
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 直播标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
