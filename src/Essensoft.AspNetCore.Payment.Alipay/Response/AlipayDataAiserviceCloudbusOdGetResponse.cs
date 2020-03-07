using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
