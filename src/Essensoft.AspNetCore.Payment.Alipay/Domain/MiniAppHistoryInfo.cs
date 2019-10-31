using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppHistoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppHistoryInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 小程序slogan
        /// </summary>
        [JsonProperty("slogan")]
        public string Slogan { get; set; }
    }
}
