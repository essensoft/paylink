using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderCreateModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsInboundorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 入库通知单主体
        /// </summary>
        [JsonPropertyName("inbound_order")]
        public InboundOrder InboundOrder { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 入库通知单货品明细列表
        /// </summary>
        [JsonPropertyName("order_lines")]
        public List<InboundOrderLine> OrderLines { get; set; }
    }
}
