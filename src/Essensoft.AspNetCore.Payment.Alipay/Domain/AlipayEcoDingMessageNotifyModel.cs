using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoDingMessageNotifyModel Data Structure.
    /// </summary>
    public class AlipayEcoDingMessageNotifyModel : AlipayObject
    {
        /// <summary>
        /// 钉钉通知@人列表
        /// </summary>
        [JsonPropertyName("at_mobiles")]
        public string AtMobiles { get; set; }

        /// <summary>
        /// 钉钉通知内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 钉钉群token
        /// </summary>
        [JsonPropertyName("ding_token")]
        public string DingToken { get; set; }
    }
}
