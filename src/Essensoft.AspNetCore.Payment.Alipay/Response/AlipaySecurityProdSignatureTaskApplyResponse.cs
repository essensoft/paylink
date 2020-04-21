using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

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
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 签约认证任务列表
        /// </summary>
        [JsonPropertyName("task_list")]
        public List<SignTaskResult> TaskList { get; set; }
    }
}
