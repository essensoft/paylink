using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechDataServiceBlockchainContractQueryModel Data Structure.
    /// </summary>
    public class AnttechDataServiceBlockchainContractQueryModel : AlipayObject
    {
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
        /// 合约唯一hash
        /// </summary>
        [JsonPropertyName("contract_hash")]
        public string ContractHash { get; set; }

        /// <summary>
        /// 合约结束时间戳
        /// </summary>
        [JsonPropertyName("end_timestamp")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 分页页号
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小，最大100
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 合约起始时间戳
        /// </summary>
        [JsonPropertyName("start_timestamp")]
        public long StartTimestamp { get; set; }
    }
}
