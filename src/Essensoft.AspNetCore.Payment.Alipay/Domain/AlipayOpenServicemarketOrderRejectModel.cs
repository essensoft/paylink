using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderRejectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderRejectModel : AlipayObject
    {
        /// <summary>
        /// 订购服务商品订单ID
        /// </summary>
        [JsonProperty("commodity_order_id")]
        [XmlElement("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 拒绝接单原因
        /// </summary>
        [JsonProperty("reject_reason")]
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
