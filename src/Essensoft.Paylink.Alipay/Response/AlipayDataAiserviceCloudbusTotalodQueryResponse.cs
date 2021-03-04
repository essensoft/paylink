using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTotalodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTotalodQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 客流总量结果
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusTotalOdItem Result { get; set; }
    }
}
