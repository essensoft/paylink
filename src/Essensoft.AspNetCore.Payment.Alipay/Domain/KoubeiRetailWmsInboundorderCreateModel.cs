using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        [XmlElement("inbound_order")]
        public InboundOrder InboundOrder { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("operate_context")]
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 入库通知单货品明细列表
        /// </summary>
        [JsonProperty("order_lines")]
        [XmlArray("order_lines")]
        [XmlArrayItem("inbound_order_line")]
        public List<InboundOrderLine> OrderLines { get; set; }
    }
}
