using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechDataServiceBlockchainAccountQueryModel Data Structure.
    /// </summary>
    public class AnttechDataServiceBlockchainAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 区块链账号唯一hash
        /// </summary>
        [JsonPropertyName("account_hash")]
        public string AccountHash { get; set; }

        /// <summary>
        /// 账户状态
        /// </summary>
        [JsonPropertyName("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 金融科技租户名
        /// </summary>
        [JsonPropertyName("at_tenant_name")]
        public string AtTenantName { get; set; }

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
        /// 账户结束时间戳
        /// </summary>
        [JsonPropertyName("end_timestamp")]
        public long EndTimestamp { get; set; }

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
        /// 账户起始时间戳
        /// </summary>
        [JsonPropertyName("start_timestamp")]
        public long StartTimestamp { get; set; }
    }
}
