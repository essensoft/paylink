using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPackageCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionPackageCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 打包类型。预发包和覆盖率包
        /// </summary>
        [JsonPropertyName("package_type")]
        public string PackageType { get; set; }

        /// <summary>
        /// pid. 伙伴链路（app_origin='HUOBAN'）时必填
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
