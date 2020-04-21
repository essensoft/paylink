using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceKidsAccountConsultResponse.
    /// </summary>
    public class AlipayCommerceKidsAccountConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 是否满足开户条件
        /// </summary>
        [JsonPropertyName("can_open")]
        public bool CanOpen { get; set; }

        /// <summary>
        /// 小宝账户信息模型，包含儿童业务id等字段
        /// </summary>
        [JsonPropertyName("child_info")]
        public ChildCertInfo ChildInfo { get; set; }

        /// <summary>
        /// 下一步跳转url
        /// </summary>
        [JsonPropertyName("next_url")]
        public NextUrl NextUrl { get; set; }

        /// <summary>
        /// 关系数量上限
        /// </summary>
        [JsonPropertyName("relation_limit")]
        public long RelationLimit { get; set; }

        /// <summary>
        /// 亲子关系列表，获取家长关联的所有孩子的列表
        /// </summary>
        [JsonPropertyName("relation_list")]
        public List<RelationVO> RelationList { get; set; }
    }
}
