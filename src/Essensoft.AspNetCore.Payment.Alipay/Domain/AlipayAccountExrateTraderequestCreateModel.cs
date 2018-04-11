using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateTraderequestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateTraderequestCreateModel : AlipayObject
    {
        /// <summary>
        /// 交易请求对象内容
        /// </summary>
        [JsonProperty("trade_request")]
        [XmlElement("trade_request")]
        public TradeRequestVO TradeRequest { get; set; }
    }
}
