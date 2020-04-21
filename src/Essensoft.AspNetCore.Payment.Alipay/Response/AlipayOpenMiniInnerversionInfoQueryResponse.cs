using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionInfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 版本构建类型
        /// </summary>
        [JsonPropertyName("build_source")]
        public string BuildSource { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 版本创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 实例化模板参数
        /// </summary>
        [JsonPropertyName("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 版本更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 版本灰度时间
        /// </summary>
        [JsonPropertyName("gray_start_time")]
        public string GrayStartTime { get; set; }

        /// <summary>
        /// 小程序灰度比例值
        /// </summary>
        [JsonPropertyName("gray_strategy")]
        public string GrayStrategy { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 版本下架时间
        /// </summary>
        [JsonPropertyName("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 包地址
        /// </summary>
        [JsonPropertyName("package_url")]
        public string PackageUrl { get; set; }

        /// <summary>
        /// 引用插件信息
        /// </summary>
        [JsonPropertyName("plugin_refs")]
        public List<MiniAppPluginInfo> PluginRefs { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 版本回滚时间
        /// </summary>
        [JsonPropertyName("rollback_time")]
        public string RollbackTime { get; set; }

        /// <summary>
        /// 安全扫描结果
        /// </summary>
        [JsonPropertyName("scan_result")]
        public string ScanResult { get; set; }

        /// <summary>
        /// 小程序版本截图，多个截图以逗号隔开
        /// </summary>
        [JsonPropertyName("screen_shot_list")]
        public string ScreenShotList { get; set; }

        /// <summary>
        /// 版本上架时间
        /// </summary>
        [JsonPropertyName("shelf_time")]
        public string ShelfTime { get; set; }

        /// <summary>
        /// 源码包地址
        /// </summary>
        [JsonPropertyName("source_url")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// 版本状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模板构建参数
        /// </summary>
        [JsonPropertyName("template_extra")]
        public string TemplateExtra { get; set; }

        /// <summary>
        /// 模板版本号
        /// </summary>
        [JsonPropertyName("template_version")]
        public string TemplateVersion { get; set; }
    }
}
