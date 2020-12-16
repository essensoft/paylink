using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerContractDetailQueryResponse.
    /// </summary>
    public class ZhimaCustomerContractDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合约详情
        /// </summary>
        [JsonPropertyName("contract_detail")]
        public ApiContractDetail ContractDetail { get; set; }
    }
}
