using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerContractAcceptCreateResponse.
    /// </summary>
    public class ZhimaCustomerContractAcceptCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }
    }
}
