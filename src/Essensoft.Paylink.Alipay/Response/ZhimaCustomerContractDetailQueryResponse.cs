using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
