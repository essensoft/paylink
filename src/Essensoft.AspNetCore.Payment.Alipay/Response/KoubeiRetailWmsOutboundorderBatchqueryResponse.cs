using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundorderBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 出库通知单列表
        /// </summary>
        [JsonPropertyName("outbound_order_vo_list")]
        public List<OutboundOrderVO> OutboundOrderVoList { get; set; }
    }
}
