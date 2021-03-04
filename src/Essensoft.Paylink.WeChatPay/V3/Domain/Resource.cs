using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 通知数据
    /// </summary>
    public class Resource : WeChatPayObject
    {
        /// <summary>
        /// 原始类型
        /// </summary>
        /// <remarks>
        /// <para>示例值：transaction</para>
        /// </remarks>
        [JsonPropertyName("original_type")]
        public string OriginalType { get; set; }

        /// <summary>
        /// 加密算法类型
        /// </summary>
        /// <remarks>
        /// 对开启结果数据进行加密的加密算法，目前只支持AEAD_AES_256_GCM
        /// <para>示例值：AEAD_AES_256_GCM</para>
        /// </remarks>
        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }

        /// <summary>
        /// 数据密文
        /// </summary>
        /// <remarks>
        /// Base64编码后的开启/停用结果数据密文
        /// <para>示例值：sadsadsadsad</para>
        /// </remarks>
        [JsonPropertyName("ciphertext")]
        public string Ciphertext { get; set; }

        /// <summary>
        /// 附加数据
        /// </summary>
        /// <remarks>
        /// 附加数据
        /// <para>示例值：fdasfwqewlkja484w</para>
        /// </remarks>
        [JsonPropertyName("associated_data")]
        public string AssociatedData { get; set; }

        /// <summary>
        /// 随机串
        /// </summary>
        /// <remarks>
        /// 加密使用的随机串
        /// <para>示例值：fdasflkja484w</para>
        /// </remarks>
        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }
    }
}
