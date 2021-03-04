using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoTextDetectResponse.
    /// </summary>
    public class AlipayEcoTextDetectResponse : AlipayResponse
    {
        /// <summary>
        /// 检测结果
        /// </summary>
        [JsonPropertyName("data")]
        public List<SpiDetectionDetail> Data { get; set; }
    }
}
