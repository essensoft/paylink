using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossContractManagementCreateModel Data Structure.
    /// </summary>
    public class AlipayBossContractManagementCreateModel : AlipayObject
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

        /// <summary>
        /// 合同信息列表
        /// </summary>
        [JsonPropertyName("contract_info_list")]
        public List<ContractInfo> ContractInfoList { get; set; }

        /// <summary>
        /// 业务方流程实列ID
        /// </summary>
        [JsonPropertyName("process_instance_id")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 业务方需要推进的流程任务ID
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
