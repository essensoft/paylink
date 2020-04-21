using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerappServicePublishResponse.
    /// </summary>
    public class AlipayOpenMiniInnerappServicePublishResponse : AlipayResponse
    {
        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonPropertyName("merchandise_id")]
        public string MerchandiseId { get; set; }
    }
}
