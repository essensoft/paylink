using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// H5场景信息
    /// </summary>    
    public class H5Info : WeChatPayObject
    {
        /// <summary>
        /// 场景类型，枚举值：
        /// iOS：IOS移动应用；
        /// Android：安卓移动应用；
        /// Wap：WAP网站应用；
        /// 示例值：iOS
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 应用名称	
        /// 应用名称
        /// 示例值：王者荣耀
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 网站URL	
        /// 网站URL
        /// 示例值：https://pay.qq.com
        /// </summary>
        [JsonPropertyName("app_url")]
        public string AppUrl { get; set; }

        /// <summary>
        /// iOS平台BundleID	
        /// iOS平台BundleID
        /// 示例值：com.tencent.wzryiOS
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// Android平台PackageName	
        /// Android平台PackageName
        /// 示例值：com.tencent.tmgp.sgame
        /// </summary>
        [JsonPropertyName("package_name")]
        public string PackageName { get; set; }
    }
}
