using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTransitorridorQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTransitorridorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusTransitResultItem Result { get; set; }
    }
}
