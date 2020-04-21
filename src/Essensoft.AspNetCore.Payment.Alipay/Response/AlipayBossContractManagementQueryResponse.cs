using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
