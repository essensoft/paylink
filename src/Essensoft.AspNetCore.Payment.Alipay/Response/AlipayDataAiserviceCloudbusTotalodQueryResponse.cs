using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
