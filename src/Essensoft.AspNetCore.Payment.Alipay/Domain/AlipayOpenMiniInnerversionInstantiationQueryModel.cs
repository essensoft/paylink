using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionInstantiationQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionInstantiationQueryModel : AlipayObject
    {
        /// <summary>
        /// 来源，需要申请
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 实例化小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端id
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序appId，仅支持普通小程序、门店小程序
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
