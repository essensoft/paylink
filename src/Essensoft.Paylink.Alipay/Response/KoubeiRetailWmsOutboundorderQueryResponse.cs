using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 出库通知单明细列表
        /// </summary>
        [JsonPropertyName("outbound_order_line_list")]
        public List<OutboundOrderLine> OutboundOrderLineList { get; set; }

        /// <summary>
        /// 出库通知单
        /// </summary>
        [JsonPropertyName("outbound_order_vo")]
        public OutboundOrderVO OutboundOrderVo { get; set; }
    }
}
