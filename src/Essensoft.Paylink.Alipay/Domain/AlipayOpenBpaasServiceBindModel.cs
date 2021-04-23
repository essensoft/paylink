using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenBpaasServiceBindModel Data Structure.
    /// </summary>
    public class AlipayOpenBpaasServiceBindModel : AlipayObject
    {
        /// <summary>
        /// bpaas应用id
        /// </summary>
        [JsonPropertyName("bpaas_app_id")]
        public string BpaasAppId { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        [JsonPropertyName("bpaas_app_version")]
        public string BpaasAppVersion { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务版本
        /// </summary>
        [JsonPropertyName("service_version")]
        public string ServiceVersion { get; set; }
    }
}
