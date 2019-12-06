using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SignTaskResult Data Structure.
    /// </summary>
    public class SignTaskResult : AlipayObject
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 支付宝签约入口地址
        /// </summary>
        [JsonPropertyName("sign_enter_url")]
        public string SignEnterUrl { get; set; }

        /// <summary>
        /// 签名任务流水号
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
