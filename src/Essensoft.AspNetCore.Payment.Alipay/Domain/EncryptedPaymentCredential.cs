using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EncryptedPaymentCredential Data Structure.
    /// </summary>
    public class EncryptedPaymentCredential : AlipayObject
    {
        /// <summary>
        /// 码值密文。{Base64 encrypted data}
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 加密产生的临时公钥。 {Base64 encoded ephemeral public key}
        /// </summary>
        [JsonPropertyName("ephemeral_public_key")]
        public string EphemeralPublicKey { get; set; }

        /// <summary>
        /// 加密用的WAGU秘钥公钥Hash。 {Base64 encoded SHA-256 hash of the encoded public key used to encrypt}
        /// </summary>
        [JsonPropertyName("public_key_hash")]
        public string PublicKeyHash { get; set; }

        /// <summary>
        /// 加密版本。{Encryption version. } {ECC椭圆曲线算法+DH交换秘钥。Elliptic Curve Cryptography Version 2}
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
