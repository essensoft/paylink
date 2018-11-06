using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BuyerPayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BuyerPayDetail : AlipayObject
    {
        /// <summary>
        /// 买家支付金额
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [JsonProperty("pay_channel")]
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }
    }
}
