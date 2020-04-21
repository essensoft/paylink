using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTransferConfirmModel Data Structure.
    /// </summary>
    public class AlipayOverseasTransferConfirmModel : AlipayObject
    {
        /// <summary>
        /// 汇款相关的信息
        /// </summary>
        [JsonPropertyName("additional_transfer_details")]
        public string AdditionalTransferDetails { get; set; }

        /// <summary>
        /// 收端机构id
        /// </summary>
        [JsonPropertyName("beneficiary_agent_id")]
        public string BeneficiaryAgentId { get; set; }

        /// <summary>
        /// {}
        /// </summary>
        [JsonPropertyName("beneficiary_receipt_method")]
        public string BeneficiaryReceiptMethod { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_scene_type")]
        public string BizSceneType { get; set; }

        /// <summary>
        /// 汇款过程中的金额类型
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
        /// 汇款用户的支付方式
        /// </summary>
        [JsonPropertyName("payer_payment_method")]
        public string PayerPaymentMethod { get; set; }

        /// <summary>
        /// 汇款用户汇款的金额
        /// </summary>
        [JsonPropertyName("transfer_from_amount")]
        public Money TransferFromAmount { get; set; }

        /// <summary>
        /// 汇款通知地址
        /// </summary>
        [JsonPropertyName("transfer_notify_url")]
        public string TransferNotifyUrl { get; set; }

        /// <summary>
        /// 报价信息
        /// </summary>
        [JsonPropertyName("transfer_quote")]
        public string TransferQuote { get; set; }

        /// <summary>
        /// 汇款请求id
        /// </summary>
        [JsonPropertyName("transfer_request_id")]
        public string TransferRequestId { get; set; }

        /// <summary>
        /// 收款用户收到的金额
        /// </summary>
        [JsonPropertyName("transfer_to_amount")]
        public Money TransferToAmount { get; set; }
    }
}
