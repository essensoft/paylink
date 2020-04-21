using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MorphoCreateApp Data Structure.
    /// </summary>
    public class MorphoCreateApp : AlipayObject
    {
        /// <summary>
        /// 小程序类目
        /// </summary>
        [JsonPropertyName("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序描述
        /// </summary>
        [JsonPropertyName("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序英文名称
        /// </summary>
        [JsonPropertyName("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序LOGO
        /// </summary>
        [JsonPropertyName("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序简介
        /// </summary>
        [JsonPropertyName("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 闪蝶创建小程序类型应用时应用的业务类型，目前氛围技术型和普通型，普通型不传，技术型为：'TECHNICAL_SUPPORT'
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 小程序所属PID
        /// </summary>
        [JsonPropertyName("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 小程序ID，使用已有小程序创建闪蝶站点时使用
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 闪蝶应用名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 创建的闪蝶应用的类型：小程序、H5等
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
