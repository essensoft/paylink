using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Advert Data Structure.
    /// </summary>
    [Serializable]
    public class Advert : AlipayObject
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [JsonProperty("advert_id")]
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表
        /// </summary>
        [JsonProperty("advert_items")]
        [XmlArray("advert_items")]
        [XmlArrayItem("advert_item")]
        public List<AdvertItem> AdvertItems { get; set; }
    }
}
