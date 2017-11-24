using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SignTaskResult Data Structure.
    /// </summary>
    public class SignTaskResult : AlipayObject
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 支付宝签约入口地址
        /// </summary>
        [JsonProperty("sign_enter_url")]
        public string SignEnterUrl { get; set; }

        /// <summary>
        /// 签名任务流水号
        /// </summary>
        [JsonProperty("task_id")]
        public string TaskId { get; set; }
    }
}
