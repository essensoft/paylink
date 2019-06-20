using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageSingleSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageSingleSendModel : AlipayObject
    {
        /// <summary>
        /// 消息模板相关参数，其中包括templateId模板ID和context模板上下文
        /// </summary>
        [JsonProperty("template")]
        public Template Template { get; set; }

        /// <summary>
        /// 消息接收用户的userid
        /// </summary>
        [JsonProperty("to_user_id")]
        public string ToUserId { get; set; }
    }
}
