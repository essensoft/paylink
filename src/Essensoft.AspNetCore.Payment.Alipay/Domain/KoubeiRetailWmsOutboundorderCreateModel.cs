using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderCreateModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsOutboundorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 出库通知单货品明细列表
        /// </summary>
        [JsonPropertyName("order_lines")]
        public List<OutboundOrderLine> OrderLines { get; set; }

        /// <summary>
        /// 出库通知单主体
        /// </summary>
        [JsonPropertyName("outbound_order")]
        public OutboundOrder OutboundOrder { get; set; }
    }
}
