using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInboundorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 入库通知单主体
        /// </summary>
        [JsonProperty("inbound_order")]
        public InboundOrder InboundOrder { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 入库通知单货品明细列表
        /// </summary>
        [JsonProperty("order_lines")]
        public List<InboundOrderLine> OrderLines { get; set; }
    }
}
