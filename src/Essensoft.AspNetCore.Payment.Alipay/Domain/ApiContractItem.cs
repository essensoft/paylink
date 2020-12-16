using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApiContractItem Data Structure.
    /// </summary>
    public class ApiContractItem : AlipayObject
    {
        /// <summary>
        /// 实际逾期时间
        /// </summary>
        [JsonPropertyName("actual_due_time")]
        public string ActualDueTime { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonPropertyName("complete_time")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 逾期时间
        /// </summary>
        [JsonPropertyName("due_time")]
        public string DueTime { get; set; }

        /// <summary>
        /// 事项目标
        /// </summary>
        [JsonPropertyName("goals")]
        public List<ApiContractGoal> Goals { get; set; }

        /// <summary>
        /// 事项号
        /// </summary>
        [JsonPropertyName("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 事项期数
        /// </summary>
        [JsonPropertyName("item_phase")]
        public string ItemPhase { get; set; }

        /// <summary>
        /// PENDING_COMPLETE、COMPLETE、UNDONE、CLOSE
        /// </summary>
        [JsonPropertyName("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 发约单号
        /// </summary>
        [JsonPropertyName("offer_no")]
        public string OfferNo { get; set; }

        /// <summary>
        /// 每一期事项下的次数
        /// </summary>
        [JsonPropertyName("phase_serial_num")]
        public string PhaseSerialNum { get; set; }

        /// <summary>
        /// 模版号
        /// </summary>
        [JsonPropertyName("template_no")]
        public string TemplateNo { get; set; }
    }
}
