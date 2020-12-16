using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeMiniappBindModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAmpeMiniappBindModel : AlipayObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 需要绑定小程序的移动应用ID
        /// </summary>
        [JsonPropertyName("mobile_app_id")]
        public string MobileAppId { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
