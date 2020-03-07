using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantSignResponse.
    /// </summary>
    public class AlipayFinancialnetAuthContractMerchantSignResponse : AlipayResponse
    {
        /// <summary>
        /// 合约批次号
        /// </summary>
        [JsonPropertyName("contract_batch_no")]
        public string ContractBatchNo { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no_list")]
        public List<string> ContractNoList { get; set; }
    }
}
