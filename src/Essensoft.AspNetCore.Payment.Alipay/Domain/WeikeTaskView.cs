using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WeikeTaskView Data Structure.
    /// </summary>
    public class WeikeTaskView : AlipayObject
    {
        /// <summary>
        /// 任务视图描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 蚂蚁微客对当前任务视图编号
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 任务视图图片链接
        /// </summary>
        [JsonPropertyName("img")]
        public string Img { get; set; }

        /// <summary>
        /// 任务视图名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 任务视图对应的任务薪资
        /// </summary>
        [JsonPropertyName("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 当前任务视图剩余任务数
        /// </summary>
        [JsonPropertyName("task_count")]
        public long TaskCount { get; set; }

        /// <summary>
        /// 点击任务视图后唤起微客对应页面的链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
