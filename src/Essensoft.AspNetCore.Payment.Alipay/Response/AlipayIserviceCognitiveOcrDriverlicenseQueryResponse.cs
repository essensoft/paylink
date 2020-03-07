using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrDriverlicenseQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrDriverlicenseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("addr")]
        public string Addr { get; set; }

        /// <summary>
        /// 有效期限
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 识别错误的详细原因描述
        /// </summary>
        [JsonPropertyName("error_content")]
        public string ErrorContent { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 驾驶证号码
        /// </summary>
        [JsonPropertyName("num")]
        public string Num { get; set; }

        /// <summary>
        /// 服务器id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 有效期起始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// true:识别成功  false:识别失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 准驾车型
        /// </summary>
        [JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
