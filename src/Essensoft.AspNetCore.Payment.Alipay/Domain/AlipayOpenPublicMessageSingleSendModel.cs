using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageSingleSendModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMessageSingleSendModel : AlipayObject
    {
        /// <summary>
        /// 消息模板相关参数，其中包括templateId模板ID和context模板上下文
        /// </summary>
        [JsonPropertyName("template")]
        public Template Template { get; set; }

        /// <summary>
        /// 消息接收用户的userid
        /// </summary>
        [JsonPropertyName("to_user_id")]
        public string ToUserId { get; set; }
    }
}
