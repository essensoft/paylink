using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeSfasdfModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeSfasdfModel : AlipayObject
    {
        /// <summary>
        /// sdafsdfsaf
        /// </summary>
        [JsonProperty("adsfghjf")]
        [XmlElement("adsfghjf")]
        public AlipayItemVoucherTemplete Adsfghjf { get; set; }

        /// <summary>
        /// ghjffdssfghj
        /// </summary>
        [JsonProperty("easadasfd")]
        [XmlArray("easadasfd")]
        [XmlArrayItem("string")]
        public List<string> Easadasfd { get; set; }

        /// <summary>
        /// dsfghdsagfhd
        /// </summary>
        [JsonProperty("gdfsa")]
        [XmlArray("gdfsa")]
        [XmlArrayItem("string")]
        public List<string> Gdfsa { get; set; }

        /// <summary>
        /// ghjkhg
        /// </summary>
        [JsonProperty("hjgdfs")]
        [XmlElement("hjgdfs")]
        public string Hjgdfs { get; set; }

        /// <summary>
        /// sdgfjhkg
        /// </summary>
        [JsonProperty("sdfgsdfg")]
        [XmlArray("sdfgsdfg")]
        [XmlArrayItem("string")]
        public List<string> Sdfgsdfg { get; set; }

        /// <summary>
        /// ASGFDGASaaf
        /// </summary>
        [JsonProperty("wehtegf")]
        [XmlArray("wehtegf")]
        [XmlArrayItem("string")]
        public List<string> Wehtegf { get; set; }
    }
}
