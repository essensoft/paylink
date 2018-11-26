using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSitesCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesCreateModel : AlipayObject
    {
        /// <summary>
        /// 站点域名，默认为空间中第一个可用域名
        /// </summary>
        [JsonProperty("domain")]
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 站点过期时间，默认为发布时间 + 3 个月（调用站点发布接口时候可以再次修改）
        /// </summary>
        [JsonProperty("offline_time")]
        [XmlElement("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 站点页面在编辑器中默认展示的数据(废弃，请使用pages)
        /// </summary>
        [JsonProperty("page")]
        [XmlElement("page")]
        public FengdieActivityCreatePageData Page { get; set; }

        /// <summary>
        /// 站点页面在编辑器中默认展示的数据
        /// </summary>
        [JsonProperty("pages")]
        [XmlArray("pages")]
        [XmlArrayItem("fengdie_activity_create_pages_data")]
        public List<FengdieActivityCreatePagesData> Pages { get; set; }

        /// <summary>
        /// 站点标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
