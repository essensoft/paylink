using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionInfoDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionInfoDeleteModel : AlipayObject
    {
        /// <summary>
        /// 业务场景来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 操作者ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
