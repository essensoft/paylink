using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiProvisioningBundle Data Structure.
    /// </summary>
    public class OpenApiProvisioningBundle : AlipayObject
    {
        /// <summary>
        /// 加密后的数据
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 一次性公密钥
        /// </summary>
        [JsonPropertyName("ephemeral_public_key")]
        public string EphemeralPublicKey { get; set; }

        /// <summary>
        /// 公钥hash
        /// </summary>
        [JsonPropertyName("public_key_hash")]
        public string PublicKeyHash { get; set; }

        /// <summary>
        /// EC_v2
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
