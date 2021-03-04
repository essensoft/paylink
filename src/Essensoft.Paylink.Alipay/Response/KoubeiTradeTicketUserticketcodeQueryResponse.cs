using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
