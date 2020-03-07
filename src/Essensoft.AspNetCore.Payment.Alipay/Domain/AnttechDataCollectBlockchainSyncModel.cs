using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechDataCollectBlockchainSyncModel Data Structure.
    /// </summary>
    public class AnttechDataCollectBlockchainSyncModel : AlipayObject
    {
        /// <summary>
        /// 链上账号列表，JSON字符串
        /// </summary>
        [JsonPropertyName("account_data")]
        public string AccountData { get; set; }

        /// <summary>
        /// 区块链唯一ID
        /// </summary>
        [JsonPropertyName("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 链上合约列表，JSON字符串
        /// </summary>
        [JsonPropertyName("contract_data")]
        public string ContractData { get; set; }

        /// <summary>
        /// 截止块高
        /// </summary>
        [JsonPropertyName("end_height")]
        public long EndHeight { get; set; }

        /// <summary>
        /// 起始块高
        /// </summary>
        [JsonPropertyName("start_height")]
        public long StartHeight { get; set; }

        /// <summary>
        /// 链上交易列表，JSON字符串
        /// </summary>
        [JsonPropertyName("transaction_data")]
        public string TransactionData { get; set; }
    }
}
