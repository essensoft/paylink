using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusMetroodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusMetroodQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public MetroOdDetailResult Result { get; set; }
    }
}
