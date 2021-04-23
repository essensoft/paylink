using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeMsgRecallModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLifeMsgRecallModel : AlipayObject
    {
        /// <summary>
        /// 消息id，可在调用<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.message.total.send">群发消息</a>、<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.message.group.send">组发消息</a>接口时会返回，请注意保存留用。
        /// </summary>
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
    }
}
