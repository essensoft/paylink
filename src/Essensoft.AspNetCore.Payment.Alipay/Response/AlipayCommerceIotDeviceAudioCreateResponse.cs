using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioCreateResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceAudioCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 语音id
        /// </summary>
        [JsonPropertyName("audio_id")]
        public string AudioId { get; set; }

        /// <summary>
        /// 语音文件的地址.用户可以通过此地址试听合成的语音
        /// </summary>
        [JsonPropertyName("audio_url")]
        public string AudioUrl { get; set; }
    }
}
