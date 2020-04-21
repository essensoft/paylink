using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFingerprintVerifyInitializeModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdFingerprintVerifyInitializeModel : AlipayObject
    {
        /// <summary>
        /// IFAA协议的版本，目前为2.0
        /// </summary>
        [JsonPropertyName("ifaa_version")]
        public string IfaaVersion { get; set; }

        /// <summary>
        /// IFAA协议客户端静态信息，调用IFAA客户端SDK接口获取secData，透传至本参数。此参数是为了兼容IFAA1.0而设计的，接入方可根据是否需要接入IFAA1.0来决定是否要传(只接入IFAA2.0不需要传)
        /// </summary>
        [JsonPropertyName("sec_data")]
        public string SecData { get; set; }

        /// <summary>
        /// IFAA标准中用于关联IFAA Server和业务方Server开通状态的token，此token为注册时保存的token，传入此token，用于生成服务端校验信息。
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
