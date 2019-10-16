using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoDingMessageNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoDingMessageNotifyModel : AlipayObject
    {
        /// <summary>
        /// 钉钉通知@人列表
        /// </summary>
        [JsonProperty("at_mobiles")]
        public string AtMobiles { get; set; }

        /// <summary>
        /// 钉钉通知内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 钉钉群token
        /// </summary>
        [JsonProperty("ding_token")]
        public string DingToken { get; set; }
    }
}
