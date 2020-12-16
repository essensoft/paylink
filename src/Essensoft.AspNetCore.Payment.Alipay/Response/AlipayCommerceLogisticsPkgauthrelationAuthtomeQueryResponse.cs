using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsPkgauthrelationAuthtomeQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsPkgauthrelationAuthtomeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 授权关系列表
        /// </summary>
        [JsonPropertyName("pkg_auth_relations")]
        public List<PkgAuthRelation> PkgAuthRelations { get; set; }
    }
}
