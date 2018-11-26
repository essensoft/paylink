using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SimpleMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleMockModel : AlipayObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [JsonProperty("count_items")]
        [XmlElement("count_items")]
        public long CountItems { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [JsonProperty("happen_time")]
        [XmlElement("happen_time")]
        public string HappenTime { get; set; }

        /// <summary>
        /// 1.2f
        /// </summary>
        [JsonProperty("price_num")]
        [XmlElement("price_num")]
        public string PriceNum { get; set; }

        /// <summary>
        /// false
        /// </summary>
        [JsonProperty("right")]
        [XmlElement("right")]
        public bool Right { get; set; }

        /// <summary>
        /// trade_no
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
