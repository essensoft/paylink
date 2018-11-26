using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MoreInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MoreInfoDTO : AlipayObject
    {
        /// <summary>
        /// 选择opennative的时候必须填写descs的内容
        /// </summary>
        [JsonProperty("descs")]
        [XmlArray("descs")]
        [XmlArrayItem("string")]
        public List<string> Descs { get; set; }

        /// <summary>
        /// 扩展参数，需要URL地址回带的值，JSON格式(openweb时填)
        /// </summary>
        [JsonProperty("params")]
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 二级页面标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 超链接(选择openweb的时候必须填写url参数内容)
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
