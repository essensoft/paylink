using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 加密证书信息
    /// </summary>
    public class EncryptCertificate : WeChatPayObject
    {
        /// <summary>
        /// 加密算法
        /// </summary>
        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }

        /// <summary>
        /// 加密使用的随机串初始化向量
        /// </summary>
        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// 附加数据包
        /// </summary>
        [JsonPropertyName("associated_data")]
        public string AssociatedData { get; set; }

        /// <summary>
        /// Base64编码后的密文
        /// </summary>
        [JsonPropertyName("ciphertext")]
        public string Ciphertext { get; set; }
    }
}
