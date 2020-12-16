using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechAiCvDsbIdentifyResponse.
    /// </summary>
    public class AnttechAiCvDsbIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 本次inference任务id，后续通过该id查询对应结果
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
