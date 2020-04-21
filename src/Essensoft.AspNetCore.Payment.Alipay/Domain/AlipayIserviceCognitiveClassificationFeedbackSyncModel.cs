using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationFeedbackSyncModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveClassificationFeedbackSyncModel : AlipayObject
    {
        /// <summary>
        /// 反馈结果：同意，修正，忽略
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 业务编码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 图片url，或者文本
        /// </summary>
        [JsonPropertyName("cognition_content")]
        public string CognitionContent { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [JsonPropertyName("cognition_type")]
        public string CognitionType { get; set; }

        /// <summary>
        /// 用户反馈的垃圾类别
        /// </summary>
        [JsonPropertyName("feedback_category")]
        public string FeedbackCategory { get; set; }

        /// <summary>
        /// 用户反馈的正确的垃圾名称
        /// </summary>
        [JsonPropertyName("feedback_rubbish")]
        public string FeedbackRubbish { get; set; }

        /// <summary>
        /// 预测的垃圾类别
        /// </summary>
        [JsonPropertyName("predict_category")]
        public string PredictCategory { get; set; }

        /// <summary>
        /// 垃圾名称
        /// </summary>
        [JsonPropertyName("predict_rubbish")]
        public string PredictRubbish { get; set; }

        /// <summary>
        /// traceid
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
