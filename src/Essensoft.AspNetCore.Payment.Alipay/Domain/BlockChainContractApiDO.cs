using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BlockChainContractApiDO Data Structure.
    /// </summary>
    public class BlockChainContractApiDO : AlipayObject
    {
        /// <summary>
        /// 合约定义
        /// </summary>
        [JsonPropertyName("abi")]
        public string Abi { get; set; }

        /// <summary>
        /// 区块链ID
        /// </summary>
        [JsonPropertyName("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 区块链块hash
        /// </summary>
        [JsonPropertyName("block_hash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// 智能科技统一客户ID
        /// </summary>
        [JsonPropertyName("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 代码hash
        /// </summary>
        [JsonPropertyName("code_hash")]
        public string CodeHash { get; set; }

        /// <summary>
        /// 合约hash
        /// </summary>
        [JsonPropertyName("contract_hash")]
        public string ContractHash { get; set; }

        /// <summary>
        /// 合约时间戳
        /// </summary>
        [JsonPropertyName("contract_timestamp")]
        public long ContractTimestamp { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonPropertyName("contract_version")]
        public long ContractVersion { get; set; }

        /// <summary>
        /// 二进制字节码
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 交易hash
        /// </summary>
        [JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }
    }
}
