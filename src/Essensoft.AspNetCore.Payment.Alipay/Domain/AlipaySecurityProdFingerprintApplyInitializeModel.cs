using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFingerprintApplyInitializeModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdFingerprintApplyInitializeModel : AlipayObject
    {
        /// <summary>
        /// IFAA标准中的校验类型，目前1为指纹
        /// </summary>
        [JsonPropertyName("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// IFAA协议的版本，目前为2.0
        /// </summary>
        [JsonPropertyName("ifaa_version")]
        public string IfaaVersion { get; set; }

        /// <summary>
        /// IFAA协议客户端静态信息，调用IFAA客户端SDK接口获取secData，透传至本参数
        /// </summary>
        [JsonPropertyName("sec_data")]
        public string SecData { get; set; }
    }
}
