using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceSubmitModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceSubmitModel : AlipayObject
    {
        /// <summary>
        /// 小目标实例ID
        /// </summary>
        [JsonPropertyName("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 调用方标识
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
