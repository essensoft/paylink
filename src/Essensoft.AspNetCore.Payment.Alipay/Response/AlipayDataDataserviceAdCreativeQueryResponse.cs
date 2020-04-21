using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 创意详情
        /// </summary>
        [JsonPropertyName("creative_detail")]
        public CreativeDetail CreativeDetail { get; set; }
    }
}
