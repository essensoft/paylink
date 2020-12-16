using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMarketMultibundleConsultModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMarketMultibundleConsultModel : AlipayObject
    {
        /// <summary>
        /// 端ID
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 商户小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 场景值，用于区分营销场景，例如打车星巴克
        /// </summary>
        [JsonPropertyName("scenes")]
        public string Scenes { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
