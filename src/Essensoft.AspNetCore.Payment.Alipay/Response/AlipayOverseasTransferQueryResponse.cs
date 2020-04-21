using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTransferQueryResponse.
    /// </summary>
    public class AlipayOverseasTransferQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 收款人附属信息
        /// </summary>
        [JsonPropertyName("additional_beneficiary_details")]
        public string AdditionalBeneficiaryDetails { get; set; }

        /// <summary>
        /// 收端机构id
        /// </summary>
        [JsonPropertyName("beneficiary_agent_id")]
        public string BeneficiaryAgentId { get; set; }

        /// <summary>
        /// 汇款指令金额类型，表示期望汇款的固定一方金额
        /// </summary>
        [JsonPropertyName("instructed_amount_type")]
        public string InstructedAmountType { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构id
        /// </summary>
        [JsonPropertyName("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 转账人付款总量 json对象
        /// </summary>
        [JsonPropertyName("transfer_from_amount")]
        public string TransferFromAmount { get; set; }

        /// <summary>
        /// 汇款id
        /// </summary>
        [JsonPropertyName("transfer_id")]
        public string TransferId { get; set; }

        /// <summary>
        /// 报价信息json对象
        /// </summary>
        [JsonPropertyName("transfer_quote")]
        public string TransferQuote { get; set; }

        /// <summary>
        /// transferResult的json对象
        /// </summary>
        [JsonPropertyName("transfer_result")]
        public string TransferResult { get; set; }

        /// <summary>
        /// 汇款成功实践
        /// </summary>
        [JsonPropertyName("transfer_time")]
        public string TransferTime { get; set; }

        /// <summary>
        /// 收款人收款总量 json对象
        /// </summary>
        [JsonPropertyName("transfer_to_amount")]
        public string TransferToAmount { get; set; }
    }
}
