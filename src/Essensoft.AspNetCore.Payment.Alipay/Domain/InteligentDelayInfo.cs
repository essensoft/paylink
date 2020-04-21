using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentDelayInfo Data Structure.
    /// </summary>
    public class InteligentDelayInfo : AlipayObject
    {
        /// <summary>
        /// 延迟类型，目前支持以下类型  ABSOLUTELY：按绝对值延迟  BYDAY：按天延迟
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 延迟值，单位分钟  按绝对值延迟延迟24*60 (1天)表示，当日08:00:00领到的券要到隔日的08:00:00才能使用  按天延迟延迟24*60(1天)表示，当日08:00:00领到的券，隔日00:00:00点就可以用
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
