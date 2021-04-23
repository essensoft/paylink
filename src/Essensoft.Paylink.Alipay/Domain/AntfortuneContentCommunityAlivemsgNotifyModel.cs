using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityAlivemsgNotifyModel Data Structure.
    /// </summary>
    public class AntfortuneContentCommunityAlivemsgNotifyModel : AlipayObject
    {
        /// <summary>
        /// 淘宝直播id
        /// </summary>
        [JsonPropertyName("live_id")]
        public string LiveId { get; set; }

        /// <summary>
        /// 0:直播中, 1:直播结束，-1:直播不存在, 2: 预约，3：暂停，4：未开始(端上使用)
        /// </summary>
        [JsonPropertyName("live_status")]
        public string LiveStatus { get; set; }

        /// <summary>
        /// 淘宝用户ID
        /// </summary>
        [JsonPropertyName("tb_user_id")]
        public string TbUserId { get; set; }
    }
}
