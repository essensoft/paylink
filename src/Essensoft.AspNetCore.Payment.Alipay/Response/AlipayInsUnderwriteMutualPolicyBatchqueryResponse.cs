using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsUnderwriteMutualPolicyBatchqueryResponse.
    /// </summary>
    public class AlipayInsUnderwriteMutualPolicyBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 宝贝计划ID
        /// </summary>
        [JsonPropertyName("plan_no")]
        public string PlanNo { get; set; }

        /// <summary>
        /// 保单ID列表,json格式
        /// </summary>
        [JsonPropertyName("policy_nos")]
        public List<string> PolicyNos { get; set; }
    }
}
