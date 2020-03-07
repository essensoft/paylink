using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BlockChainTransactionApiDO Data Structure.
    /// </summary>
    public class BlockChainTransactionApiDO : AlipayObject
    {
        /// <summary>
        /// 区块链ID
        /// </summary>
        [JsonPropertyName("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 块hash
        /// </summary>
        [JsonPropertyName("block_hash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// 块高
        /// </summary>
        [JsonPropertyName("block_height")]
        public long BlockHeight { get; set; }

        /// <summary>
        /// 智能科技统一客户ID
        /// </summary>
        [JsonPropertyName("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 起始账户
        /// </summary>
        [JsonPropertyName("from_account")]
        public string FromAccount { get; set; }

        /// <summary>
        /// gas消耗
        /// </summary>
        [JsonPropertyName("gas_used")]
        public long GasUsed { get; set; }

        /// <summary>
        /// 目标账户
        /// </summary>
        [JsonPropertyName("to_account")]
        public string ToAccount { get; set; }

        /// <summary>
        /// 交易hash
        /// </summary>
        [JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// 交易时间戳
        /// </summary>
        [JsonPropertyName("transaction_timestamp")]
        public long TransactionTimestamp { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonPropertyName("transaction_type")]
        public long TransactionType { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
