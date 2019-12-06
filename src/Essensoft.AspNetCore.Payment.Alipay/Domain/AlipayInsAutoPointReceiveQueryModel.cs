using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoPointReceiveQueryModel Data Structure.
    /// </summary>
    public class AlipayInsAutoPointReceiveQueryModel : AlipayObject
    {
        /// <summary>
        /// 车险活动类型编码。  攒油活动：SAVE_OIL
        /// </summary>
        [JsonPropertyName("auto_campaign_type")]
        public string AutoCampaignType { get; set; }

        /// <summary>
        /// 车险活动接入场景码。  例如，车险攒油活动接入场景码。  高德导航：gaode_use
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
