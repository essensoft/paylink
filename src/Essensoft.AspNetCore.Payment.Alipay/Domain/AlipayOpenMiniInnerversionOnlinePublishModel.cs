using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionOnlinePublishModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionOnlinePublishModel : AlipayObject
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
        /// 否服务降级，如果降级，拉包策略如果端上有本地包，则使用本地包打开，同时异步下载新包，待下次打开则使用新包
        /// </summary>
        [JsonPropertyName("downgrade")]
        public bool Downgrade { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序所属PID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// normal默认普通发布，high 高保发布
        /// </summary>
        [JsonPropertyName("release_type")]
        public string ReleaseType { get; set; }
    }
}
