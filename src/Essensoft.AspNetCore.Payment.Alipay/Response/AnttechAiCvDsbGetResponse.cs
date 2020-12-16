using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechAiCvDsbGetResponse.
    /// </summary>
    public class AnttechAiCvDsbGetResponse : AlipayResponse
    {
        /// <summary>
        /// 定损结果的下载链接，15分钟内有效
        /// </summary>
        [JsonPropertyName("result_url")]
        public string ResultUrl { get; set; }

        /// <summary>
        /// 总共3个状态：RUNNING，SUCC，FAILED
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 请求参数内传入的task_id
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
