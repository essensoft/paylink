using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeCreditProductSignModel Data Structure.
    /// </summary>
    public class AlipayTradeCreditProductSignModel : AlipayObject
    {
        /// <summary>
        /// 扩展值
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 生效模型策略
        /// </summary>
        [JsonPropertyName("valid_strategy")]
        public OpenApiValidStrategy ValidStrategy { get; set; }
    }
}
