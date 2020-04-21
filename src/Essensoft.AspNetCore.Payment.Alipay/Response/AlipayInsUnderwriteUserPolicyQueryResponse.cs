using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsUnderwriteUserPolicyQueryResponse.
    /// </summary>
    public class AlipayInsUnderwriteUserPolicyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的用户拥有的保单列表，含所有查询状态对应的保单，排序规则按照，保险保障开始时间倒序
        /// </summary>
        [JsonPropertyName("policys")]
        public List<InsPolicy> Policys { get; set; }

        /// <summary>
        /// 结果的总条数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
