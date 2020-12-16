using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SiteResult Data Structure.
    /// </summary>
    public class SiteResult : AlipayObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("data")]
        public List<SiteItem> Data { get; set; }

        /// <summary>
        /// 返回消息提示
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 任务结果列表
        /// </summary>
        [JsonPropertyName("task_list")]
        public List<SitePlanItem> TaskList { get; set; }
    }
}
