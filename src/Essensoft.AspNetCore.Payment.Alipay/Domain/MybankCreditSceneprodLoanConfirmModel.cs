using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodLoanConfirmModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodLoanConfirmModel : AlipayObject
    {
        /// <summary>
        /// 网商针对一次客户主动申请生成的申请单据编号
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 审核结果，通过：approved，拒绝：refused
        /// </summary>
        [JsonPropertyName("approve_result")]
        public string ApproveResult { get; set; }

        /// <summary>
        /// 证件主体名称
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 资方生成的申请单号
        /// </summary>
        [JsonPropertyName("fin_order_no")]
        public string FinOrderNo { get; set; }

        /// <summary>
        /// 拒绝码，通过填写00
        /// </summary>
        [JsonPropertyName("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因，审核通过可不传
        /// </summary>
        [JsonPropertyName("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 终审备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 标识一次业务交互, 网商的ipRoleId+"_"YYYYMMDD+35位流水号, 最后2，3位要求是数字。
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
