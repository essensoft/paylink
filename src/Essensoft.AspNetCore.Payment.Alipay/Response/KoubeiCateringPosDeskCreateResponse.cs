using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskCreateResponse.
    /// </summary>
    public class KoubeiCateringPosDeskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 桌位ID
        /// </summary>
        [JsonPropertyName("ids")]
        public List<string> Ids { get; set; }
    }
}
