using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceDataScenicMappingQueryResponse.
    /// </summary>
    public class AlipayCommerceDataScenicMappingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 景区审核信息查询结果
        /// </summary>
        [JsonPropertyName("scenic_audit_response")]
        public ScenicAuditResponse ScenicAuditResponse { get; set; }
    }
}
