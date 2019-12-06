using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BPOpenApiPUID Data Structure.
    /// </summary>
    public class BPOpenApiPUID : AlipayObject
    {
        /// <summary>
        /// 系统名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务ID，对应业务单条记录的ID
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型。不要填写下划线、点等特殊符号
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 一般留空。如果一个biz_id可发起多个流程实例，则填写此值
        /// </summary>
        [JsonPropertyName("unique_key")]
        public string UniqueKey { get; set; }
    }
}
