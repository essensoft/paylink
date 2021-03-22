using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossContractGeneralCreateResponse.
    /// </summary>
    public class AlipayBossContractGeneralCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 发起审批返回结果
        /// </summary>
        [JsonPropertyName("result_set")]
        public InterTradetContractOpenApiStartResult ResultSet { get; set; }
    }
}
