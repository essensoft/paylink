using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WeikeTaskView Data Structure.
    /// </summary>
    [Serializable]
    public class WeikeTaskView : AlipayObject
    {
        /// <summary>
        /// 任务视图描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 蚂蚁微客对当前任务视图编号
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 任务视图图片链接
        /// </summary>
        [JsonProperty("img")]
        public string Img { get; set; }

        /// <summary>
        /// 任务视图名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 任务视图对应的任务薪资
        /// </summary>
        [JsonProperty("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 当前任务视图剩余任务数
        /// </summary>
        [JsonProperty("task_count")]
        public long TaskCount { get; set; }

        /// <summary>
        /// 点击任务视图后唤起微客对应页面的链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
