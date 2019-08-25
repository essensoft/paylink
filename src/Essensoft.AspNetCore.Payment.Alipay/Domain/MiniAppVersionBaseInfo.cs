using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppVersionBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppVersionBaseInfo : AlipayObject
    {
        /// <summary>
        /// 开发者版本
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 01 自创建 02 模板构建
        /// </summary>
        [JsonProperty("build_source")]
        public string BuildSource { get; set; }

        /// <summary>
        /// 端标识
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 模板实例化小程序参数
        /// </summary>
        [JsonProperty("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 灰度开始时间
        /// </summary>
        [JsonProperty("gray_start_time")]
        public string GrayStartTime { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [JsonProperty("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 下架时间
        /// </summary>
        [JsonProperty("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 包地址
        /// </summary>
        [JsonProperty("package_url")]
        public string PackageUrl { get; set; }

        /// <summary>
        /// 插件plugin包地址
        /// </summary>
        [JsonProperty("plugin_url")]
        public string PluginUrl { get; set; }

        /// <summary>
        /// 回滚时间
        /// </summary>
        [JsonProperty("rollback_time")]
        public string RollbackTime { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [JsonProperty("shelf_time")]
        public string ShelfTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子状态
        /// </summary>
        [JsonProperty("sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        /// 构建模板参数
        /// </summary>
        [JsonProperty("template_extra")]
        public string TemplateExtra { get; set; }

        /// <summary>
        /// 模板应用ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [JsonProperty("template_version")]
        public string TemplateVersion { get; set; }
    }
}
