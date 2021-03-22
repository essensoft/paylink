using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmIsvInitializeModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmIsvInitializeModel : AlipayObject
    {
        /// <summary>
        /// 用于接入CCM iframe接口安全认证的 ISV 公钥，采用 base64 编码，秘钥对生成算法为 RSA2048。
        /// </summary>
        [JsonPropertyName("isv_pub_key")]
        public string IsvPubKey { get; set; }
    }
}
