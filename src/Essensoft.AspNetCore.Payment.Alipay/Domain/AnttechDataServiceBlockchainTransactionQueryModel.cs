using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechDataServiceBlockchainTransactionQueryModel Data Structure.
    /// </summary>
    public class AnttechDataServiceBlockchainTransactionQueryModel : AlipayObject
    {
        /// <summary>
        /// 区块链ID
        /// </summary>
        [JsonPropertyName("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 区块链块唯一hash
        /// </summary>
        [JsonPropertyName("block_hash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// 交易结束时间戳
        /// </summary>
        [JsonPropertyName("end_timestamp")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 交易来源账户
        /// </summary>
        [JsonPropertyName("from_account")]
        public string FromAccount { get; set; }

        /// <summary>
        /// 分页页号
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 交易开始时间戳
        /// </summary>
        [JsonPropertyName("start_timestamp")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 交易目标账户
        /// </summary>
        [JsonPropertyName("to_account")]
        public string ToAccount { get; set; }

        /// <summary>
        /// 交易唯一hash
        /// </summary>
        [JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonPropertyName("transaction_type")]
        public long TransactionType { get; set; }
    }
}
