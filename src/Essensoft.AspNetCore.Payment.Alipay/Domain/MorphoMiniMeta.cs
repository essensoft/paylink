using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MorphoMiniMeta Data Structure.
    /// </summary>
    public class MorphoMiniMeta : AlipayObject
    {
        /// <summary>
        /// 小程序的名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 最新构建版本
        /// </summary>
        [JsonPropertyName("builded_version")]
        public string BuildedVersion { get; set; }

        /// <summary>
        /// 小程序LOGO
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 当前线上版本
        /// </summary>
        [JsonPropertyName("online_version")]
        public string OnlineVersion { get; set; }

        /// <summary>
        /// 小程序状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
