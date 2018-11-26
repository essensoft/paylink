using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdSignatureTaskQueryResponse.
    /// </summary>
    public class AlipaySecurityProdSignatureTaskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单业务流水号，与alipay.security.prod.signature.task.apply接口入参biz_id对应。
        /// </summary>
        [JsonProperty("biz_id")]
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonProperty("order_id")]
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态，取值枚举如下：  a. INIT : 初始化态，用户还未进入签约。  b. FAIL ：签约失败。  c. SUCCESS ：签约成功  d. PROCESS ：签约进行中  e. EXPIRED ：当前签约任务已过期，用户无法继续操作。  f. CANCEL ：签约任务被撤销
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约任务查询结果
        /// </summary>
        [JsonProperty("task_list")]
        [XmlArray("task_list")]
        [XmlArrayItem("sign_task_file_result")]
        public List<SignTaskFileResult> TaskList { get; set; }
    }
}
