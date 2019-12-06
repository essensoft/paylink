using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

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
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态，取值枚举如下：  a. INIT : 初始化态，用户还未进入签约。  b. FAIL ：签约失败。  c. SUCCESS ：签约成功  d. PROCESS ：签约进行中  e. EXPIRED ：当前签约任务已过期，用户无法继续操作。  f. CANCEL ：签约任务被撤销
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约任务查询结果
        /// </summary>
        [JsonPropertyName("task_list")]
        public List<SignTaskFileResult> TaskList { get; set; }
    }
}
