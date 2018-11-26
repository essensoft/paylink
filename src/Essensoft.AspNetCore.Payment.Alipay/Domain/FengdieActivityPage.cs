using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieActivityPage Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivityPage : AlipayObject
    {
        /// <summary>
        /// H5页面唯一id，创建H5应用时自动生成
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// H5页面名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// H5页面schema数据
        /// </summary>
        [JsonProperty("schema")]
        [XmlArray("schema")]
        [XmlArrayItem("fengdie_activity_schema_data")]
        public List<FengdieActivitySchemaData> Schema { get; set; }

        /// <summary>
        /// H5页面预览图
        /// </summary>
        [JsonProperty("snapshot")]
        [XmlElement("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// H5页面中文标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// H5页面访问地址
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
