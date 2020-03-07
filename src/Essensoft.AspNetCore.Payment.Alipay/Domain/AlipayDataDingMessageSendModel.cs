using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDingMessageSendModel Data Structure.
    /// </summary>
    public class AlipayDataDingMessageSendModel : AlipayObject
    {
        /// <summary>
        /// access_token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 通知内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
