using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommerceAppUploadRequestContent Data Structure.
    /// </summary>
    public class CommerceAppUploadRequestContent : AlipayObject
    {
        /// <summary>
        /// 租户应用业务流程ID
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 租户应用业务流程内容
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        /// 租户应用ID
        /// </summary>
        [JsonPropertyName("tenant_app_id")]
        public string TenantAppId { get; set; }
    }
}
