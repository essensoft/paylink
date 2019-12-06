using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAgentSignstatusQueryResponse.
    /// </summary>
    public class AlipayOpenAgentSignstatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户产品签约状态结果对象数组，返回本次查询的产品的签约状态
        /// </summary>
        [JsonPropertyName("sign_status_list")]
        public List<ProductSignStatusInfo> SignStatusList { get; set; }
    }
}
