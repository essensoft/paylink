using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneMarketingContentGroup Data Structure.
    /// </summary>
    [Serializable]
    public class SceneMarketingContentGroup : AlipayObject
    {
        /// <summary>
        /// 营销内容列表
        /// </summary>
        [JsonProperty("data_list")]
        [XmlArray("data_list")]
        [XmlArrayItem("scene_marketing_content")]
        public List<SceneMarketingContent> DataList { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [JsonProperty("group_name")]
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 简要描述
        /// </summary>
        [JsonProperty("summary")]
        [XmlElement("summary")]
        public string Summary { get; set; }
    }
}
