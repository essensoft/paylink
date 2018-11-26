using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundInfo : AlipayObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品单ID
        /// </summary>
        [JsonProperty("item_order_no")]
        [XmlElement("item_order_no")]
        public string ItemOrderNo { get; set; }
    }
}
