using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityInitializeResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 返回给调用方的数据集合，具体数据由对接过程中双方共同确认
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 身份核实校验结果失败时，返回的失败错误原因说明
        /// </summary>
        [JsonPropertyName("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 身份核实校验结果失败时，返回的失败错误码身份核实校验结果失败时，返回的失败错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 核身初始化是否成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 核身页面url
        /// </summary>
        [JsonPropertyName("verify_url")]
        public string VerifyUrl { get; set; }

        /// <summary>
        /// 核身校验token，核身会话中唯一性token，用于后续核身结果二次校验时参数传入
        /// </summary>
        [JsonPropertyName("veritfy_token")]
        public string VeritfyToken { get; set; }
    }
}
