using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 通知数据
    /// </summary>
    public class Resource : WeChatPayObject
    {
        /// <summary>
        /// 原始类型
        /// 示例值：transaction
        /// </summary>
        [JsonPropertyName("original_type")]
        public string OriginalType { get; set; }

        /// <summary>
        /// 加密算法类型
        /// 对开启结果数据进行加密的加密算法，目前只支持AEAD_AES_256_GCM
        /// 示例值：AEAD_AES_256_GCM
        /// </summary>
        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }

        /// <summary>
        /// 数据密文
        /// Base64编码后的开启/停用结果数据密文
        /// 示例值：sadsadsadsad
        /// </summary>
        [JsonPropertyName("ciphertext")]
        public string Ciphertext { get; set; }

        /// <summary>
        /// 附加数据
        /// 附加数据
        /// 示例值：fdasfwqewlkja484w
        /// </summary>
        [JsonPropertyName("associated_data")]
        public string AssociatedData { get; set; }

        /// <summary>
        /// 随机串
        /// 加密使用的随机串
        /// 示例值：fdasflkja484w
        /// </summary>
        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }
    }
}
