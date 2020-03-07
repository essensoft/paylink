using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionSubstatusModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionSubstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 小程序开发版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端标识 淘宝：com.taobao.app 支付宝：com.alipay.alipaywallet
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户编码
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 子状态
        /// </summary>
        [JsonPropertyName("sub_status")]
        public string SubStatus { get; set; }
    }
}
