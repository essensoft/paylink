using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseRelationCombinedQueryResponse.
    /// </summary>
    public class AlipaySocialBaseRelationCombinedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 复合关系数据
        /// </summary>
        [JsonPropertyName("relation_combined_list")]
        public List<RelationCombinedVO> RelationCombinedList { get; set; }
    }
}
