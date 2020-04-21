using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstancesQueryResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstancesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户实例的查询结果集
        /// </summary>
        [JsonPropertyName("instances")]
        public List<QuestInstanceDTO> Instances { get; set; }
    }
}
