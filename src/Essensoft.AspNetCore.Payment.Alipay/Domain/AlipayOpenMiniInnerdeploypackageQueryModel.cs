using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerdeploypackageQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerdeploypackageQueryModel : AlipayObject
    {
        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 开发者标识的版本
        /// </summary>
        [JsonPropertyName("developer_version")]
        public string DeveloperVersion { get; set; }

        /// <summary>
        /// 租户类型，由应用中心分配
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
