using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdGroupQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 单元详情
        /// </summary>
        [JsonPropertyName("group_detail")]
        public OuterGroup GroupDetail { get; set; }
    }
}
