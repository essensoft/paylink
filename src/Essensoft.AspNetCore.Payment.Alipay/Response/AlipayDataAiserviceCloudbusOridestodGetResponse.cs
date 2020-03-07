using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
