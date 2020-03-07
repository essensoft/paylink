using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppVersionInfo Data Structure.
    /// </summary>
    public class AppVersionInfo : AlipayObject
    {
        /// <summary>
        /// 版本号，一般为x.y.x格式，其中x、y、z都是数字
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端信息，默认为支付宝端
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 版本创建时间，精确到秒
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 版本描述，介绍此版本的主要变更和功能
        /// </summary>
        [JsonPropertyName("version_description")]
        public string VersionDescription { get; set; }

        /// <summary>
        /// 版本状态，可选值为：INIT: 开发中, AUDITING: 审核中, AUDIT_REJECT: 审核驳回, WAIT_RELEASE: 待上架, GRAY: 灰度中, RELEASE: 已上架, OFFLINE: 已下架, AUDIT_OFFLINE: 被强制下架;
        /// </summary>
        [JsonPropertyName("version_status")]
        public string VersionStatus { get; set; }
    }
}
