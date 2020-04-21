using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionOnlineModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionOnlineModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数，可不选，默认支付宝端
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }
    }
}
