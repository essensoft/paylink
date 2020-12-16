using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BindedMiniAppInfo Data Structure.
    /// </summary>
    public class BindedMiniAppInfo : AlipayObject
    {
        /// <summary>
        /// 开发者名称
        /// </summary>
        [JsonPropertyName("dev_name")]
        public string DevName { get; set; }

        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序logo url地址
        /// </summary>
        [JsonPropertyName("mini_app_logo")]
        public string MiniAppLogo { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonPropertyName("mini_app_name")]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 小程序的简介
        /// </summary>
        [JsonPropertyName("mini_app_slogan")]
        public string MiniAppSlogan { get; set; }

        /// <summary>
        /// true：小程序在架 false：小程序当前未在架
        /// </summary>
        [JsonPropertyName("online")]
        public bool Online { get; set; }

        /// <summary>
        /// 当前小程序是否加入AMPE计划，小程序开发者可以自行进行AMPE的开通和关闭
        /// </summary>
        [JsonPropertyName("support_ampe")]
        public bool SupportAmpe { get; set; }
    }
}
