using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMallEventSendResponse.
    /// </summary>
    public class KoubeiMallEventSendResponse : AlipayResponse
    {
        /// <summary>
        /// 事件ID
        /// </summary>
        [JsonPropertyName("event_id")]
        public string EventId { get; set; }
    }
}
