using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageTotalSendModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMessageTotalSendModel : AlipayObject
    {
        /// <summary>
        /// 图文消息，当 msg_type为image-text，本参数必填。 
        /// </summary>
        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 当msg_type为text，本参数必填。
        /// </summary>
        [JsonPropertyName("text")]
        public Text Text { get; set; }
    }
}
