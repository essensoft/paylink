using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MultiAppBaseInfoDto Data Structure.
    /// </summary>
    [Serializable]
    public class MultiAppBaseInfoDto : AlipayObject
    {
        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [JsonProperty("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用logo图标
        /// </summary>
        [JsonProperty("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 1：表示上线状态 0：表示下架状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
