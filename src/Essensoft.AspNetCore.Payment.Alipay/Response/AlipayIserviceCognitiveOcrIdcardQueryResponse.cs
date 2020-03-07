using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrIdcardQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrIdcardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 出生年月日
        /// </summary>
        [JsonPropertyName("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 有效期截止时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 信息抽取失败后详细错误原因
        /// </summary>
        [JsonPropertyName("error_content")]
        public string ErrorContent { get; set; }

        /// <summary>
        /// 公安局分案
        /// </summary>
        [JsonPropertyName("issue")]
        public string Issue { get; set; }

        /// <summary>
        /// 身份证姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 号码
        /// </summary>
        [JsonPropertyName("num")]
        public string Num { get; set; }

        /// <summary>
        /// 服务器内部id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 性别：男/女
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// true: 解析成功  false: 解析失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
