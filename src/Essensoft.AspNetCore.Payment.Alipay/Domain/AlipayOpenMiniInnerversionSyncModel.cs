using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务参数来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 推送的小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        [JsonPropertyName("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 同送方式
        /// </summary>
        [JsonPropertyName("sync_type")]
        public string SyncType { get; set; }
    }
}
