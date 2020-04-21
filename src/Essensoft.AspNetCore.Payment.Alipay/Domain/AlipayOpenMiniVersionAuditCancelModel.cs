using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionAuditCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionAuditCancelModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号, 可不选, 默认撤消正在审核中的版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数，可不选，默认支付宝端(com.alipay.alipaywallet:支付宝端)
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }
    }
}
