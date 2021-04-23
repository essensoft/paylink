using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CustomVoiceVO Data Structure.
    /// </summary>
    public class CustomVoiceVO : AlipayObject
    {
        /// <summary>
        /// 语音文件id
        /// </summary>
        [JsonPropertyName("audio_id")]
        public string AudioId { get; set; }
    }
}
