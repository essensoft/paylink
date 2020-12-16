using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareFatigueSyncModel Data Structure.
    /// </summary>
    public class AlipaySocialQuestionnareFatigueSyncModel : AlipayObject
    {
        /// <summary>
        /// 异步问卷投递时间
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 问券Id
        /// </summary>
        [JsonPropertyName("qstn_id")]
        public string QstnId { get; set; }

        /// <summary>
        /// 1 表示是离线投放后同步 2 表示用户答完问卷同步
        /// </summary>
        [JsonPropertyName("sync_type")]
        public string SyncType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID,已异步投递问卷的用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
