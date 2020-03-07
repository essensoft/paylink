using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoTrafficCodeVerifyModel Data Structure.
    /// </summary>
    public class AlipayEcoTrafficCodeVerifyModel : AlipayObject
    {
        /// <summary>
        /// 凭证服务类型
        /// </summary>
        [JsonPropertyName("cert_service_type")]
        public string CertServiceType { get; set; }

        /// <summary>
        /// 凭证类型（卡类型）
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 码值/脱机记录
        /// </summary>
        [JsonPropertyName("offline_cert")]
        public string OfflineCert { get; set; }

        /// <summary>
        /// 解析类型：QRCODE/RECORD
        /// </summary>
        [JsonPropertyName("parse_mode")]
        public string ParseMode { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
