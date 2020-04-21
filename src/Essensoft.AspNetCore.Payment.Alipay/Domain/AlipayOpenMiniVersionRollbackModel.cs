using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionRollbackModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionRollbackModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数，可不传。默认支付宝端
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }
    }
}
