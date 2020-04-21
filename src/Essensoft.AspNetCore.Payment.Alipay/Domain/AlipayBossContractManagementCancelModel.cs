using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossContractManagementCancelModel Data Structure.
    /// </summary>
    public class AlipayBossContractManagementCancelModel : AlipayObject
    {
        /// <summary>
        /// 访问接口的来源（如：采购系统-ALI_PURCHASE_SYSTEM）
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
