using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdSignatureTaskApplyResponse.
    /// </summary>
    public class AlipaySecurityProdSignatureTaskApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 签约订单id，关联了若干个签约任务id。
        /// </summary>
        [JsonProperty("order_id")]
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 签约认证任务列表
        /// </summary>
        [JsonProperty("task_list")]
        [XmlArray("task_list")]
        [XmlArrayItem("sign_task_result")]
        public List<SignTaskResult> TaskList { get; set; }
    }
}
