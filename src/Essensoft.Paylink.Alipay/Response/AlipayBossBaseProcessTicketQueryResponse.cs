using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossBaseProcessTicketQueryResponse.
    /// </summary>
    public class AlipayBossBaseProcessTicketQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 工单详情
        /// </summary>
        [JsonPropertyName("ticket")]
        public BPOpenApiTicket Ticket { get; set; }
    }
}
