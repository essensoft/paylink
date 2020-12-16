using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniModelQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniModelQueryModel : AlipayObject
    {
        /// <summary>
        /// 内容：app_info表最新更新时间，格式：时间戳
        /// </summary>
        [JsonPropertyName("app_info_modified")]
        public string AppInfoModified { get; set; }

        /// <summary>
        /// 内容：app_version表最新更新时间，格式：时间戳
        /// </summary>
        [JsonPropertyName("app_version_modified")]
        public string AppVersionModified { get; set; }

        /// <summary>
        /// 内容：deploy_package表最新更新时间，格式：时间戳
        /// </summary>
        [JsonPropertyName("deploy_package_modified")]
        public string DeployPackageModified { get; set; }

        /// <summary>
        /// 内容：deploy_window表最新更新时间，格式：时间戳
        /// </summary>
        [JsonPropertyName("deploy_window_modified")]
        public string DeployWindowModified { get; set; }

        /// <summary>
        /// 租户类型，由应用中心分配
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 是否为压测流量，true为是，默认false
        /// </summary>
        [JsonPropertyName("load_test")]
        public string LoadTest { get; set; }

        /// <summary>
        /// APPID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 内容：mini_app_version表最新更新时间，格式：时间戳
        /// </summary>
        [JsonPropertyName("mini_app_version_modified")]
        public string MiniAppVersionModified { get; set; }
    }
}
