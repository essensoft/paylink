using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrBusinesslicenseQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrBusinesslicenseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 住所
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [JsonPropertyName("business")]
        public string Business { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [JsonPropertyName("captial")]
        public string Captial { get; set; }

        /// <summary>
        /// 识别错误情况下的，详细错误原因
        /// </summary>
        [JsonPropertyName("error_content")]
        public string ErrorContent { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [JsonPropertyName("establish_date")]
        public string EstablishDate { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [JsonPropertyName("person")]
        public string Person { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [JsonPropertyName("reg_num")]
        public string RegNum { get; set; }

        /// <summary>
        /// 服务器id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// true: 识别成功  false：识别失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        [JsonPropertyName("valid_period")]
        public string ValidPeriod { get; set; }
    }
}
