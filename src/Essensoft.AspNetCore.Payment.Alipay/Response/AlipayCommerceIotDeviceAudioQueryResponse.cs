using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceAudioQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备上的语音列表.格式为json字符串. audioId为语音id,playType为播放场景,取值为TRADE或CUSTOM_AUDIO
        /// </summary>
        [JsonPropertyName("audio_list")]
        public string AudioList { get; set; }
    }
}
