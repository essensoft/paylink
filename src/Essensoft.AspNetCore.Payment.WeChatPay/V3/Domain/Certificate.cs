using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 平台证书信息
    /// </summary>
    public class Certificate : WeChatPayObject
    {
        /// <summary>
        /// 序列号
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 加密证书信息
        /// </summary>
        [JsonPropertyName("encrypt_certificate")]
        public EncryptCertificate EncryptCertificate { get; set; }
    }
}
