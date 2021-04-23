using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTransferConsultModel Data Structure.
    /// </summary>
    public class AlipayOverseasTransferConsultModel : AlipayObject
    {
        /// <summary>
        /// 汇款相关信息
        /// </summary>
        [JsonPropertyName("additional_transfer_details")]
        public string AdditionalTransferDetails { get; set; }

        /// <summary>
        /// 收端用户收款的方式
        /// </summary>
        [JsonPropertyName("beneficiary_receipt_method")]
        public string BeneficiaryReceiptMethod { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_scene_type")]
        public string BizSceneType { get; set; }

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
        /// 汇出金额
        /// </summary>
        [JsonPropertyName("transfer_to_amount")]
        public Money TransferToAmount { get; set; }
    }
}
