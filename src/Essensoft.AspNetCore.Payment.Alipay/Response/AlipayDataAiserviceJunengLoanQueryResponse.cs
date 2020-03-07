using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceJunengLoanQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceJunengLoanQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 二级错误码，帮助诊断错误
        /// </summary>
        [JsonPropertyName("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 用户身份证的md5加密值
        /// </summary>
        [JsonPropertyName("hashed_cert_no")]
        public string HashedCertNo { get; set; }

        /// <summary>
        /// 本次请求的uuid
        /// </summary>
        [JsonPropertyName("request_uuid")]
        public string RequestUuid { get; set; }

        /// <summary>
        /// 接口的返回结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
