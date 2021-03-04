using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusOridestodGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusOridestodGetResponse : AlipayResponse
    {
        /// <summary>
        /// 7OD  结果
        /// </summary>
        [JsonPropertyName("result")]
        public List<OriDestOdItem> Result { get; set; }
    }
}
