using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityConfirmResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 返回给调用方的数据集合，具体数据由对接过程中双方共同确认
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 身份核实校验结果失败时，返回的失败错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 身份核实校验结果失败时，返回的失败错误原因说明
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 身份核验结果
        /// </summary>
        [JsonPropertyName("verify_result")]
        public bool VerifyResult { get; set; }
    }
}
