using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAppdeployBydeployversionQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAppdeployBydeployversionQueryModel : AlipayObject
    {
        /// <summary>
        /// 客户端标识
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 发布标识
        /// </summary>
        [JsonPropertyName("deploy_version")]
        public string DeployVersion { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
