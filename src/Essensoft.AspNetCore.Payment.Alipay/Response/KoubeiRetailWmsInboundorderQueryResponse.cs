using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 入库通知单明细列表
        /// </summary>
        [JsonPropertyName("inbound_order_line_list")]
        public List<InboundOrderLine> InboundOrderLineList { get; set; }

        /// <summary>
        /// 入库通知单信息
        /// </summary>
        [JsonPropertyName("inbound_order_vo")]
        public InboundOrderVO InboundOrderVo { get; set; }
    }
}
