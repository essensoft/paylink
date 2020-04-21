using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantUnsignResponse.
    /// </summary>
    public class AlipayFinancialnetAuthContractMerchantUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 合约批次号列表
        /// </summary>
        [JsonPropertyName("contract_batch_no_list")]
        public List<string> ContractBatchNoList { get; set; }

        /// <summary>
        /// 合约号列表
        /// </summary>
        [JsonPropertyName("contract_no_list")]
        public List<string> ContractNoList { get; set; }
    }
}
