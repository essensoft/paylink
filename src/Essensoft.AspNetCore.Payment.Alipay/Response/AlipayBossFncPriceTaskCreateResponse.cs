using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncPriceTaskCreateResponse.
    /// </summary>
    public class AlipayBossFncPriceTaskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 价格任务创建的返回结果
        /// </summary>
        [JsonPropertyName("task_detail")]
        public string TaskDetail { get; set; }
    }
}
