using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BlockChainAccountApiDO Data Structure.
    /// </summary>
    public class BlockChainAccountApiDO : AlipayObject
    {
        /// <summary>
        /// 账户hash
        /// </summary>
        [JsonPropertyName("account_hash")]
        public string AccountHash { get; set; }

        /// <summary>
        /// 账户序号
        /// </summary>
        [JsonPropertyName("account_index")]
        public long AccountIndex { get; set; }

        /// <summary>
        /// 账户名
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户状态
        /// </summary>
        [JsonPropertyName("account_status")]
        public long AccountStatus { get; set; }

        /// <summary>
        /// 账户余额
        /// </summary>
        [JsonPropertyName("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 区块链唯一ID
        /// </summary>
        [JsonPropertyName("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 账号所在块hash
        /// </summary>
        [JsonPropertyName("block_hash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// 智能科技统一客户ID
        /// </summary>
        [JsonPropertyName("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 父账号hash
        /// </summary>
        [JsonPropertyName("parent_hash")]
        public string ParentHash { get; set; }

        /// <summary>
        /// 创建账号的交易hash
        /// </summary>
        [JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }
    }
}
