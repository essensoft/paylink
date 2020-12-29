using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceKidsRelationQueryResponse.
    /// </summary>
    public class AlipayCommerceKidsRelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 孩子信息列表
        /// </summary>
        [JsonPropertyName("relation_list")]
        public List<UserInfoVO> RelationList { get; set; }
    }
}
