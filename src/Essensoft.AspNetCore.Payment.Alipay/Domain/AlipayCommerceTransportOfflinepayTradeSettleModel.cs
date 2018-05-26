using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayTradeSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOfflinepayTradeSettleModel : AlipayObject
    {
        /// <summary>
        /// 脱机交易列表
        /// </summary>
        [JsonProperty("trade_list")]
        [XmlArray("trade_list")]
        [XmlArrayItem("alipay_offline_trade")]
        public List<AlipayOfflineTrade> TradeList { get; set; }
    }
}
