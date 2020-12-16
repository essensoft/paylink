using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmIsvInitializeModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmIsvInitializeModel : AlipayObject
    {
        /// <summary>
        /// 用于接入ccm iframe接口安全认证的isv公钥，采用base64编码，秘钥对生成算法:RSA2048
        /// </summary>
        [JsonPropertyName("isv_pub_key")]
        public string IsvPubKey { get; set; }
    }
}
