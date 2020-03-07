using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceDmpserviceCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceDmpserviceCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 服务端的处理时间
        /// </summary>
        [JsonPropertyName("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 0: 提交成功 1: 提交失败
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
