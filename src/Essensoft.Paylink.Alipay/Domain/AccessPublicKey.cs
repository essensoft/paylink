using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AccessPublicKey Data Structure.
    /// </summary>
    public class AccessPublicKey : AlipayObject
    {
        /// <summary>
        /// 公钥id
        /// </summary>
        [JsonPropertyName("key_id")]
        public long KeyId { get; set; }

        /// <summary>
        /// 公钥内容
        /// </summary>
        [JsonPropertyName("public_key")]
        public string PublicKey { get; set; }
    }
}
