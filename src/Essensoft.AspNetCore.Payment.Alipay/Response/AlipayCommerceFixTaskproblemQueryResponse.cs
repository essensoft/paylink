using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceFixTaskproblemQueryResponse.
    /// </summary>
    public class AlipayCommerceFixTaskproblemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的问题信息列表
        /// </summary>
        [JsonPropertyName("problem_list")]
        public List<FixProblemDTO> ProblemList { get; set; }
    }
}
