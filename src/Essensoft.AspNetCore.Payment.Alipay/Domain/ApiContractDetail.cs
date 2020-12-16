using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApiContractDetail Data Structure.
    /// </summary>
    public class ApiContractDetail : AlipayObject
    {
        /// <summary>
        /// 合约取消时间
        /// </summary>
        [JsonPropertyName("cancel_date")]
        public string CancelDate { get; set; }

        /// <summary>
        /// 合约完结时间
        /// </summary>
        [JsonPropertyName("complete_date")]
        public string CompleteDate { get; set; }

        /// <summary>
        /// 合约事项列表
        /// </summary>
        [JsonPropertyName("contract_items")]
        public List<ApiContractItem> ContractItems { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// INIT、EFFECT、COMPLETE、CLOSE、INVALID
        /// </summary>
        [JsonPropertyName("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// APPLY_CANCEL、CANCEL_CONFIRM、CANCEL_FORCE、REFUSE、UNDONE
        /// </summary>
        [JsonPropertyName("contract_sub_status")]
        public string ContractSubStatus { get; set; }

        /// <summary>
        /// 合约生效时间
        /// </summary>
        [JsonPropertyName("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 约定失效时间
        /// </summary>
        [JsonPropertyName("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 事项列表(废弃)
        /// </summary>
        [JsonPropertyName("items")]
        public ApiContractItem Items { get; set; }

        /// <summary>
        /// 历史加入人次
        /// </summary>
        [JsonPropertyName("join_history_people")]
        public long JoinHistoryPeople { get; set; }

        /// <summary>
        /// 发约单号
        /// </summary>
        [JsonPropertyName("offer_no")]
        public string OfferNo { get; set; }

        /// <summary>
        /// 发约主体id
        /// </summary>
        [JsonPropertyName("offer_principal_id")]
        public string OfferPrincipalId { get; set; }

        /// <summary>
        /// 参与者列表
        /// </summary>
        [JsonPropertyName("participants")]
        public List<ApiContractParticipant> Participants { get; set; }

        /// <summary>
        /// 模版号
        /// </summary>
        [JsonPropertyName("template_no")]
        public string TemplateNo { get; set; }
    }
}
