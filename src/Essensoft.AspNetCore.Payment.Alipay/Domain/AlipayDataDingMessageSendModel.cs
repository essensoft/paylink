using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDingMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDingMessageSendModel : AlipayObject
    {
        /// <summary>
        /// access_token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 通知内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
