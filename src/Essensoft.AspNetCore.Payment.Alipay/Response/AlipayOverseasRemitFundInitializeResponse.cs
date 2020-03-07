using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasRemitFundInitializeResponse.
    /// </summary>
    public class AlipayOverseasRemitFundInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 合规检查的业务结果
        /// </summary>
        [JsonPropertyName("compliance_check_result")]
        public string ComplianceCheckResult { get; set; }

        /// <summary>
        /// 合规检查的所有结果
        /// </summary>
        [JsonPropertyName("compliance_check_result_info")]
        public string ComplianceCheckResultInfo { get; set; }

        /// <summary>
        /// 合规检查结果的签名
        /// </summary>
        [JsonPropertyName("compliance_result_signature")]
        public string ComplianceResultSignature { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 外部单据号
        /// </summary>
        [JsonPropertyName("external_biz_no")]
        public string ExternalBizNo { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [JsonPropertyName("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [JsonPropertyName("sender_mid")]
        public string SenderMid { get; set; }
    }
}
