using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoTextVoiceTransferModel Data Structure.
    /// </summary>
    public class AlipayEcoTextVoiceTransferModel : AlipayObject
    {
        /// <summary>
        /// 被叫号码
        /// </summary>
        [JsonPropertyName("called_number")]
        public string CalledNumber { get; set; }

        /// <summary>
        /// 内部系统编码，回调消息将回传
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// Tts模板ID
        /// </summary>
        [JsonPropertyName("tts_code")]
        public string TtsCode { get; set; }

        /// <summary>
        /// 替换TTS模板中变量的Map
        /// </summary>
        [JsonPropertyName("tts_param")]
        public string TtsParam { get; set; }
    }
}
