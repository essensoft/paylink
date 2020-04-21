using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusHistorygeoQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusHistorygeoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 地图问题geo hash码
        /// </summary>
        [JsonPropertyName("result")]
        public List<string> Result { get; set; }
    }
}
