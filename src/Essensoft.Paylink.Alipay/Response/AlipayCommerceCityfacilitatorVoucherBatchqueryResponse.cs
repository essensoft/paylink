using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的订单信息列表
        /// </summary>
        [JsonPropertyName("tickets")]
        public List<TicketDetailInfo> Tickets { get; set; }
    }
}
