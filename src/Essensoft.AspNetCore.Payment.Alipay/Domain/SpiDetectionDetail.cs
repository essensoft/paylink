using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpiDetectionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SpiDetectionDetail : AlipayObject
    {
        /// <summary>
        /// 检测结果码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 检测内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 检测外部任务编号
        /// </summary>
        [JsonProperty("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 检测细节，检测内容可能涉及多个场景
        /// </summary>
        [JsonProperty("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 检测结果分类
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// 检测结果信息
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 检测准确率
        /// </summary>
        [JsonProperty("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 检测场景
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 检测建议 pass-文本正常 review-需要人工审核 block-文本违规，可以直接删除或者做限制处理
        /// </summary>
        [JsonProperty("suggestion")]
        public string Suggestion { get; set; }

        /// <summary>
        /// 检测内部任务编号
        /// </summary>
        [JsonProperty("task_id")]
        public string TaskId { get; set; }
    }
}
