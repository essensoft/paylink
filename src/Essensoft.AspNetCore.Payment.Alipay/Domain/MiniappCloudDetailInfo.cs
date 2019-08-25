using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniappCloudDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniappCloudDetailInfo : AlipayObject
    {
        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [JsonProperty("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        [JsonProperty("app_english_name")]
        public string AppEnglishName { get; set; }

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
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        [JsonProperty("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 生活服务_汽车服务
        /// </summary>
        [JsonProperty("category_names")]
        public string CategoryNames { get; set; }

        /// <summary>
        /// 小程序创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 小程序应用的appid
        /// </summary>
        [JsonProperty("mini_appid")]
        public string MiniAppid { get; set; }
    }
}
