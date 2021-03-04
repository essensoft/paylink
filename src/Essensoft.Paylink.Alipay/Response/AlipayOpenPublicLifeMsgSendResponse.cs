using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeMsgSendResponse.
    /// </summary>
    public class AlipayOpenPublicLifeMsgSendResponse : AlipayResponse
    {
        /// <summary>
        /// 生活号消息唯一标识
        /// </summary>
        [JsonPropertyName("alipay_msg_id")]
        public string AlipayMsgId { get; set; }
    }
}
