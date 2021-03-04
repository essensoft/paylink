using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
