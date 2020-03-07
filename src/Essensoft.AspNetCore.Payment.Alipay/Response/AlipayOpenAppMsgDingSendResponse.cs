using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppMsgDingSendResponse.
    /// </summary>
    public class AlipayOpenAppMsgDingSendResponse : AlipayResponse
    {
        /// <summary>
        /// 企业消息的id
        /// </summary>
        [JsonPropertyName("msg_id")]
        public string MsgId { get; set; }
    }
}
