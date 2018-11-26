using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ModelMeta Data Structure.
    /// </summary>
    [Serializable]
    public class ModelMeta : AlipayObject
    {
        /// <summary>
        /// 模型描述
        /// </summary>
        [JsonProperty("model_desc")]
        [XmlElement("model_desc")]
        public string ModelDesc { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("model_name")]
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 模型唯一查询标识符
        /// </summary>
        [JsonProperty("model_uk")]
        [XmlElement("model_uk")]
        public string ModelUk { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        [JsonProperty("query_key")]
        [XmlArray("query_key")]
        [XmlArrayItem("string")]
        public List<string> QueryKey { get; set; }
    }
}
