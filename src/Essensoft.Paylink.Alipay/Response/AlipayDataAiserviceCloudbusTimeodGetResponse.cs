using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTimeodGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTimeodGetResponse : AlipayResponse
    {
        /// <summary>
        /// od分时结果列表
        /// </summary>
        [JsonPropertyName("result")]
        public List<CloudbusTimeOdItem> Result { get; set; }
    }
}
