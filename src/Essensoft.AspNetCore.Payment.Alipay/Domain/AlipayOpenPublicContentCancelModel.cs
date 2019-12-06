using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicContentCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicContentCancelModel : AlipayObject
    {
        /// <summary>
        /// message_id 是发布接口调用之后拿到的返回值，用来撤回已经发布的对应内容
        /// </summary>
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
    }
}
