using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// NotifyUserVo Data Structure.
    /// </summary>
    public class NotifyUserVo : AlipayObject
    {
        /// <summary>
        /// 删除标志，已删除：deleted, 未删除:not_deleted
        /// </summary>
        [JsonPropertyName("del_flag")]
        public string DelFlag { get; set; }

        /// <summary>
        /// 订阅服务唯一标识
        /// </summary>
        [JsonPropertyName("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 订阅实体
        /// </summary>
        [JsonPropertyName("notify_object")]
        public string NotifyObject { get; set; }

        /// <summary>
        /// 订阅状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
