using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolMessageSendResponse.
    /// </summary>
    public class AlipayCommerceIotSdarttoolMessageSendResponse : AlipayResponse
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonPropertyName("message_no")]
        public string MessageNo { get; set; }
    }
}
