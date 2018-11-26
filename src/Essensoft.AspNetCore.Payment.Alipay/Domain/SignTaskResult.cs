using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SignTaskResult Data Structure.
    /// </summary>
    [Serializable]
    public class SignTaskResult : AlipayObject
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonProperty("biz_id")]
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 支付宝签约入口地址
        /// </summary>
        [JsonProperty("sign_enter_url")]
        [XmlElement("sign_enter_url")]
        public string SignEnterUrl { get; set; }

        /// <summary>
        /// 签名任务流水号
        /// </summary>
        [JsonProperty("task_id")]
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
