using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBuildauditSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionBuildauditSubmitModel : AlipayObject
    {
        /// <summary>
        /// 小程序类目，可不传，不传取基础信息中的小程序类目
        /// </summary>
        [JsonProperty("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序描述，可不传，不传取基础信息中的小程序描述
        /// </summary>
        [JsonProperty("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序英文名称，可不传，不传取基础信息中的小程序英文名称
        /// </summary>
        [JsonProperty("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo，可不传，不传取基础信息中的小程序logo
        /// </summary>
        [JsonProperty("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序名称，可不传，不传取基础信息中的小程序名称
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonProperty("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序简介，可不传，不传取基础信息中的小程序简介
        /// </summary>
        [JsonProperty("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 构建扩展参数
        /// </summary>
        [JsonProperty("build_ext")]
        public string BuildExt { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 三方应用ID
        /// </summary>
        [JsonProperty("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 提审时，选择的所属类目需要校验营业执照，可不传，不传取基础信息中的小程序英文名称
        /// </summary>
        [JsonProperty("license_info")]
        public AuditLicenseInfo LicenseInfo { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序开发者ID，可不传，不传取基础信息中的小程序开发者ID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 服务区域类型,可不传，不传取基础信息中的小程序服务区域类型
        /// </summary>
        [JsonProperty("region_type")]
        public string RegionType { get; set; }

        /// <summary>
        /// 版本截图，最少2张，最多5张，必传
        /// </summary>
        [JsonProperty("screen_shot_list")]
        public string ScreenShotList { get; set; }

        /// <summary>
        /// 客服电话，可不传，不传取基础信息中的小程序客服电话
        /// </summary>
        [JsonProperty("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 小程序模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 基于模板构建，模板小程序的版本号，不传，默认取最新版本号
        /// </summary>
        [JsonProperty("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [JsonProperty("version_desc")]
        public string VersionDesc { get; set; }
    }
}
