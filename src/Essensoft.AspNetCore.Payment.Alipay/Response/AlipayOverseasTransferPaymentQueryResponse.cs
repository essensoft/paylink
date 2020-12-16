using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentQueryResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 收款人明细
        /// </summary>
        [JsonPropertyName("additional_beneficiary_details")]
        public string AdditionalBeneficiaryDetails { get; set; }

        /// <summary>
        /// 汇款指令金额类型，表示期望汇款的固定一方金额
        /// </summary>
        [JsonPropertyName("instructed_amount_type")]
        public string InstructedAmountType { get; set; }

        /// <summary>
        /// 透传字段，采用key-value的方式存储
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 汇款金额（from）
        /// </summary>
        [JsonPropertyName("transfer_from_amount")]
        public string TransferFromAmount { get; set; }

        /// <summary>
        /// 主站交易流水号
        /// </summary>
        [JsonPropertyName("transfer_id")]
        public string TransferId { get; set; }

        /// <summary>
        /// 汇款结果
        /// </summary>
        [JsonPropertyName("transfer_result")]
        public string TransferResult { get; set; }

        /// <summary>
        /// 汇款时间
        /// </summary>
        [JsonPropertyName("transfer_time")]
        public string TransferTime { get; set; }

        /// <summary>
        /// 汇款金额（to）
        /// </summary>
        [JsonPropertyName("transfer_to_amount")]
        public string TransferToAmount { get; set; }
    }
}
