using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeTicketUserticketcodeQueryResponse.
    /// </summary>
    public class KoubeiTradeTicketUserticketcodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询结果列表
        /// </summary>
        [JsonPropertyName("values")]
        public List<TicketCodeQueryResponse> Values { get; set; }
    }
}
