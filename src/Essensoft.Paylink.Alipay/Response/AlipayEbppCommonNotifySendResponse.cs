using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommonNotifySendResponse.
    /// </summary>
    public class AlipayEbppCommonNotifySendResponse : AlipayResponse
    {
        /// <summary>
        /// 通知的执行结果
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
