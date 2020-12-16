using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolTaskReceiveResponse.
    /// </summary>
    public class AlipayMarketingToolTaskReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 阶段码。applet_signup任务报名。
        /// </summary>
        [JsonPropertyName("stage_code")]
        public string StageCode { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
