using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataSoundSetModel Data Structure.
    /// </summary>
    public class AlipayDataSoundSetModel : AlipayObject
    {
        /// <summary>
        /// 应用token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用秘钥
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 音量
        /// </summary>
        [JsonPropertyName("voice")]
        public long Voice { get; set; }

        /// <summary>
        /// 蜂鸣器
        /// </summary>
        [JsonPropertyName("voice_type")]
        public string VoiceType { get; set; }
    }
}
