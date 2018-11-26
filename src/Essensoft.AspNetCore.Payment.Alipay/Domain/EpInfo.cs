using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EpInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpInfo : AlipayObject
    {
        /// <summary>
        /// 企业征信元素列表，如一套企业工商照面信息。数据长度不定。
        /// </summary>
        [JsonProperty("ep_element_list")]
        [XmlArray("ep_element_list")]
        [XmlArrayItem("ep_element")]
        public List<EpElement> EpElementList { get; set; }
    }
}
