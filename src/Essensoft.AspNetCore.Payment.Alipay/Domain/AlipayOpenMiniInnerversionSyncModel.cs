using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务参数来源
        /// </summary>
        [JsonProperty("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 推送的小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        [JsonProperty("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 同送方式
        /// </summary>
        [JsonProperty("sync_type")]
        public string SyncType { get; set; }
    }
}
