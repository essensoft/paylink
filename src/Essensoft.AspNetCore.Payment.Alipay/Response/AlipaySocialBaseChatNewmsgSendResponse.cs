using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseChatNewmsgSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatNewmsgSendResponse : AlipayResponse
    {
        /// <summary>
        /// 消息索引号 会话ID_消息ID
        /// </summary>
        [JsonPropertyName("msg_index")]
        public string MsgIndex { get; set; }
    }
}
