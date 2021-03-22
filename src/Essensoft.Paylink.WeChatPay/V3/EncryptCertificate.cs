using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// 加密证书信息
    /// </summary>
    public class EncryptCertificate : WeChatPayObject
    {
        /// <summary>
        /// 加密算法类型
        /// </summary>
        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }

        /// <summary>
        /// 随机串
        /// </summary>
        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// 附加数据
        /// </summary>
        [JsonPropertyName("associated_data")]
        public string AssociatedData { get; set; }

        /// <summary>
        /// 数据密文
        /// </summary>
        [JsonPropertyName("ciphertext")]
        public string Ciphertext { get; set; }
    }
}
