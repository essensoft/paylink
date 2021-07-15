using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InstallmentDetail Data Structure.
    /// </summary>
    public class InstallmentDetail : AlipayObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 结清状态，SETTLED - 结清；NOT_SETTLE - 未结清
        /// </summary>
        [JsonPropertyName("is_settle")]
        public string IsSettle { get; set; }

        /// <summary>
        /// 分期期次
        /// </summary>
        [JsonPropertyName("period")]
        public long Period { get; set; }

        /// <summary>
        /// 减免利息
        /// </summary>
        [JsonPropertyName("reduce_interest")]
        public long ReduceInterest { get; set; }

        /// <summary>
        /// 减免复利
        /// </summary>
        [JsonPropertyName("reduce_interest_penalty")]
        public long ReduceInterestPenalty { get; set; }

        /// <summary>
        /// 减免罚息
        /// </summary>
        [JsonPropertyName("reduce_penalty")]
        public long ReducePenalty { get; set; }

        /// <summary>
        /// 已还利息 - 该期累计实还利息
        /// </summary>
        [JsonPropertyName("repaid_interest_amount")]
        public long RepaidInterestAmount { get; set; }

        /// <summary>
        /// 已还复利 - 该期累计实还复利
        /// </summary>
        [JsonPropertyName("repaid_interest_penalty_amount")]
        public long RepaidInterestPenaltyAmount { get; set; }

        /// <summary>
        /// 已还罚息 - 该期累计实还罚息
        /// </summary>
        [JsonPropertyName("repaid_penalty_amount")]
        public long RepaidPenaltyAmount { get; set; }

        /// <summary>
        /// 已还本金 - 该期累计实还本金
        /// </summary>
        [JsonPropertyName("repaid_principal_amount")]
        public long RepaidPrincipalAmount { get; set; }

        /// <summary>
        /// 剩余利息 - 该期剩余应还利息
        /// </summary>
        [JsonPropertyName("rest_interest")]
        public long RestInterest { get; set; }

        /// <summary>
        /// 剩余复利 - 该期剩余应还复利
        /// </summary>
        [JsonPropertyName("rest_interest_penalty")]
        public long RestInterestPenalty { get; set; }

        /// <summary>
        /// 剩余罚息 - 该期剩余应还罚息
        /// </summary>
        [JsonPropertyName("rest_penalty")]
        public long RestPenalty { get; set; }

        /// <summary>
        /// 剩余本金 - 该期剩余应还本金
        /// </summary>
        [JsonPropertyName("rest_principal")]
        public long RestPrincipal { get; set; }
    }
}
