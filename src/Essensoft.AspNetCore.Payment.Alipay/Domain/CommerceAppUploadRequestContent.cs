using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommerceAppUploadRequestContent Data Structure.
    /// </summary>
    [Serializable]
    public class CommerceAppUploadRequestContent : AlipayObject
    {
        /// <summary>
        /// 租户应用业务流程ID
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 租户应用业务流程内容
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// 租户应用ID
        /// </summary>
        [JsonProperty("tenant_app_id")]
        public string TenantAppId { get; set; }
    }
}
