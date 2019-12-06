using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveAswfDagQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveAswfDagQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务唯一标识，不可空
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务的任务描述
        /// </summary>
        [JsonPropertyName("ctxs")]
        public string Ctxs { get; set; }

        /// <summary>
        /// DAG模板ID，不可空
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 业务请求唯一id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
