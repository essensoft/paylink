using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppCommunityUserpromoSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenAppCommunityUserpromoSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务数据
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 场景来源(创建时必填，其他更新时可以不填)
        /// </summary>
        [JsonPropertyName("scene_src")]
        public string SceneSrc { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 发放对象
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 营销活动类型（券/红包/xxx）
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝用户user_id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
