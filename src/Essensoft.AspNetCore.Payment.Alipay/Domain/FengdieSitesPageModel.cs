using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSitesPageModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesPageModel : AlipayObject
    {
        /// <summary>
        /// 站点页面别名
        /// </summary>
        [JsonProperty("alias")]
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// H5页面预览图
        /// </summary>
        [JsonProperty("snapshot")]
        [XmlElement("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 页面访问地址
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
