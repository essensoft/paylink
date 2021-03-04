using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusOdGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusOdGetResponse : AlipayResponse
    {
        /// <summary>
        /// od结果
        /// </summary>
        [JsonPropertyName("result")]
        public List<CloudBusOdItem> Result { get; set; }
    }
}
