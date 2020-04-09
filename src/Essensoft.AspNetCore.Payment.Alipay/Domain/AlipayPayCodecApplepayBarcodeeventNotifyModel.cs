using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayCodecApplepayBarcodeeventNotifyModel Data Structure.
    /// </summary>
    public class AlipayPayCodecApplepayBarcodeeventNotifyModel : AlipayObject
    {
        /// <summary>
        /// 码的id。{Identifier for this credential}
        /// </summary>
        [JsonPropertyName("barcode_identifier")]
        public string BarcodeIdentifier { get; set; }

        /// <summary>
        /// 上报事件，Base64 encoded UTF-8 bytes of Event Data JSON object defined below.
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; set; }

        /// <summary>
        /// 上报时间的签名，Base64 encoded PKCS#7 detached ECDSA signature. Signature data is generated over the SHA- 256 hash of Base64 decoded event bytes。
        /// </summary>
        [JsonPropertyName("signature")]
        public string Signature { get; set; }
    }
}
