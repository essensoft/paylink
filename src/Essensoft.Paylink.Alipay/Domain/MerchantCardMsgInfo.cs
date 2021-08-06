using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MerchantCardMsgInfo Data Structure.
    /// </summary>
    public class MerchantCardMsgInfo : AlipayObject
    {
        /// <summary>
        /// 本次消息通知的变动积分，积分必须为数字型（可为浮点型，带2位小数点），格式非法则不发送消息。例如： 100，则代表增加100积分。 -100，则代表减少100积分。
        /// </summary>
        [JsonPropertyName("changed_point")]
        public string ChangedPoint { get; set; }
    }
}
