using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedExtensionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展区套数
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 扩展区信息
        /// </summary>
        [JsonPropertyName("extensions")]
        public List<QueryExtension> Extensions { get; set; }
    }
}
