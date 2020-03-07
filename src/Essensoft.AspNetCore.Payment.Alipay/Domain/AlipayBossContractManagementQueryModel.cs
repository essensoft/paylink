using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossContractManagementQueryModel Data Structure.
    /// </summary>
    public class AlipayBossContractManagementQueryModel : AlipayObject
    {
        /// <summary>
        /// 来源（如：采购系统-ALI_PURCHASE_SYSTEM）
        /// </summary>
        [JsonPropertyName("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 合约批次号
        /// </summary>
        [JsonPropertyName("contract_batch_no")]
        public string ContractBatchNo { get; set; }
    }
}
