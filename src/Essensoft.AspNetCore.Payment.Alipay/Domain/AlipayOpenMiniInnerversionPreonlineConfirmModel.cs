using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPreonlineConfirmModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionPreonlineConfirmModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序Id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
