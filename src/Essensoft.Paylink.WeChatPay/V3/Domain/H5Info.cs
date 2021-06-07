using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// H5场景信息
    /// </summary>
    public class H5Info : WeChatPayObject
    {
        /// <summary>
        /// 场景类型
        /// </summary>
        /// <remarks>
        /// 场景类型，枚举值：
        /// iOS：IOS移动应用；
        /// Android：安卓移动应用；
        /// Wap：WAP网站应用；
        /// <para>示例值：iOS</para>
        /// </remarks>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        /// <remarks>
        /// 应用名称
        /// <para>示例值：王者荣耀</para>
        /// </remarks>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 网站URL
        /// </summary>
        /// <remarks>
        /// 网站URL
        /// <para>示例值：https://pay.qq.com</para>
        /// </remarks>
        [JsonPropertyName("app_url")]
        public string AppUrl { get; set; }

        /// <summary>
        /// iOS平台BundleID
        /// </summary>
        /// <remarks>
        /// iOS平台BundleID
        /// <para>示例值：com.tencent.wzryiOS</para>
        /// </remarks>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// Android平台PackageName
        /// </summary>
        /// <remarks>
        /// Android平台PackageName
        /// <para>示例值：com.tencent.tmgp.sgame</para>
        /// </remarks>
        [JsonPropertyName("package_name")]
        public string PackageName { get; set; }
    }
}
