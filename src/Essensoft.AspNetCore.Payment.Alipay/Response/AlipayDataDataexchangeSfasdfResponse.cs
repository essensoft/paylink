using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataexchangeSfasdfResponse.
    /// </summary>
    public class AlipayDataDataexchangeSfasdfResponse : AlipayResponse
    {
        /// <summary>
        /// dsfagshdj
        /// </summary>
        [JsonProperty("azxfghd")]
        [XmlArray("azxfghd")]
        [XmlArrayItem("string")]
        public List<string> Azxfghd { get; set; }

        /// <summary>
        /// asghdfsdas阿福故事、
        /// </summary>
        [JsonProperty("gfdhsdasafg")]
        [XmlArray("gfdhsdasafg")]
        [XmlArrayItem("string")]
        public List<string> Gfdhsdasafg { get; set; }

        /// <summary>
        /// fgdhjdsfgh
        /// </summary>
        [JsonProperty("gfhjfdsa")]
        [XmlArray("gfhjfdsa")]
        [XmlArrayItem("string")]
        public List<string> Gfhjfdsa { get; set; }

        /// <summary>
        /// sdfdhgjfdfsaghjfd
        /// </summary>
        [JsonProperty("ghjfdsafgh")]
        [XmlArray("ghjfdsafgh")]
        [XmlArrayItem("string")]
        public List<string> Ghjfdsafgh { get; set; }

        /// <summary>
        /// sadasff
        /// </summary>
        [JsonProperty("sdvsdv")]
        [XmlElement("sdvsdv")]
        public string Sdvsdv { get; set; }

        /// <summary>
        /// hysasd
        /// </summary>
        [JsonProperty("wrty")]
        [XmlArray("wrty")]
        [XmlArrayItem("alipay_item_goods_list")]
        public List<AlipayItemGoodsList> Wrty { get; set; }
    }
}
