using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsOutboundorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("operate_context")]
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 出库通知单货品明细列表
        /// </summary>
        [JsonProperty("order_lines")]
        [XmlArray("order_lines")]
        [XmlArrayItem("outbound_order_line")]
        public List<OutboundOrderLine> OrderLines { get; set; }

        /// <summary>
        /// 出库通知单主体
        /// </summary>
        [JsonProperty("outbound_order")]
        [XmlElement("outbound_order")]
        public OutboundOrder OutboundOrder { get; set; }
    }
}
