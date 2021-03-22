using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// LoanContractInfo Data Structure.
    /// </summary>
    public class LoanContractInfo : AlipayObject
    {
        /// <summary>
        /// 房抵贷抵押合同
        /// </summary>
        [JsonPropertyName("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合同编号 本次使用区块链上内部合同编号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合同oss 地址
        /// </summary>
        [JsonPropertyName("contract_oss_url")]
        public string ContractOssUrl { get; set; }
    }
}
