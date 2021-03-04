using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossContractManagementQueryResponse.
    /// </summary>
    public class AlipayBossContractManagementQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [JsonPropertyName("result_set")]
        public ContractBatchInfoOpenApiResult ResultSet { get; set; }
    }
}
