using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeMsgRecallModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLifeMsgRecallModel : AlipayObject
    {
        /// <summary>
        /// 消息id
        /// </summary>
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
    }
}
