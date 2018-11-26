using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataSecCheckContent Data Structure.
    /// </summary>
    [Serializable]
    public class DataSecCheckContent : AlipayObject
    {
        /// <summary>
        /// 文本或图片对应的请求唯一值，用于标识文本或图片内容
        /// </summary>
        [JsonProperty("data_id")]
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 数据来源类型:TEXT--文本，IMAGE--图片
        /// </summary>
        [JsonProperty("scene_type")]
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 待校验的文本数据(如果包含富文本，请一起传入)
        /// </summary>
        [JsonProperty("text")]
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 待校验图片对应地址
        /// </summary>
        [JsonProperty("urls")]
        [XmlArray("urls")]
        [XmlArrayItem("string")]
        public List<string> Urls { get; set; }
    }
}
