using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityDataNamelistSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataNamelistSendModel : AlipayObject
    {
        /// <summary>
        /// 业务名称,用来区分消息处理类目
        /// </summary>
        [JsonProperty("bizname")]
        public string Bizname { get; set; }

        /// <summary>
        /// json格式具体内容.
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 对方系统名称,用于追踪消息发送来源系统
        /// </summary>
        [JsonProperty("sysname")]
        public string Sysname { get; set; }
    }
}
