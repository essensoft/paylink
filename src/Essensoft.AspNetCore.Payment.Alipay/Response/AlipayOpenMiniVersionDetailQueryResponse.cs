using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionDetailQueryResponse.
    /// </summary>
    public class AlipayOpenMiniVersionDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [JsonPropertyName("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        [JsonPropertyName("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序应用logo图标
        /// </summary>
        [JsonPropertyName("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        [JsonPropertyName("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序版本提交审核的时间
        /// </summary>
        [JsonPropertyName("gmt_apply_audit")]
        public string GmtApplyAudit { get; set; }

        /// <summary>
        /// 小程序版本审核结束时间
        /// </summary>
        [JsonPropertyName("gmt_audit_end")]
        public string GmtAuditEnd { get; set; }

        /// <summary>
        /// 小程序版本创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 小程序版本下架时间
        /// </summary>
        [JsonPropertyName("gmt_offline")]
        public string GmtOffline { get; set; }

        /// <summary>
        /// 小程序版本上架时间
        /// </summary>
        [JsonPropertyName("gmt_online")]
        public string GmtOnline { get; set; }

        /// <summary>
        /// 小程序灰度比例值，p10-10%的用户，p30-30%的用户，p50-50%的用户
        /// </summary>
        [JsonPropertyName("gray_strategy")]
        public string GrayStrategy { get; set; }

        /// <summary>
        /// 小程序备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 小程序类目列表
        /// </summary>
        [JsonPropertyName("mini_app_category_info_list")]
        public List<MiniAppCategoryInfo> MiniAppCategoryInfoList { get; set; }

        /// <summary>
        /// 新小程序类目列表
        /// </summary>
        [JsonPropertyName("mini_category_info_list")]
        public List<MiniAppCategoryInfo> MiniCategoryInfoList { get; set; }

        /// <summary>
        /// 小程序功能包列表
        /// </summary>
        [JsonPropertyName("package_info_list")]
        public List<MiniPackageInfo> PackageInfoList { get; set; }

        /// <summary>
        /// 审核驳回原因
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 安全扫描结果，True-安全扫描通过，False-安全扫描不通过，NAN-扫描中
        /// </summary>
        [JsonPropertyName("scan_result")]
        public string ScanResult { get; set; }

        /// <summary>
        /// 小程序版本截图，多个截图以逗号隔开
        /// </summary>
        [JsonPropertyName("screen_shot_list")]
        public List<string> ScreenShotList { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [JsonPropertyName("service_email")]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 小程序服务区域信息，当服务区域类型是LOCATION时，这里明确指出具体的服务区域信息
        /// </summary>
        [JsonPropertyName("service_region_info")]
        public List<RegionInfo> ServiceRegionInfo { get; set; }

        /// <summary>
        /// 小程序服务区域类型，GLOBLE-全球，CHINA-中国，LOCATION-指定区域
        /// </summary>
        [JsonPropertyName("service_region_type")]
        public string ServiceRegionType { get; set; }

        /// <summary>
        /// 小程序版本状态，INIT-开发中，AUDITING-审核中，WAIT_RELEASE-审核通过，AUDIT_REJECT-审核驳回，RELEASE-已上架，GRAY-灰度中，OFFLINE-下架
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 小程序版本描述
        /// </summary>
        [JsonPropertyName("version_desc")]
        public string VersionDesc { get; set; }
    }
}
