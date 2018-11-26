using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportQueryModel : AlipayObject
    {
        /// <summary>
        /// 规则KEY
        /// </summary>
        [JsonProperty("condition_key")]
        [XmlElement("condition_key")]
        public string ConditionKey { get; set; }

        /// <summary>
        /// 额外增加的查询过滤条件
        /// </summary>
        [JsonProperty("filter_tags")]
        [XmlArray("filter_tags")]
        [XmlArrayItem("filter_tag")]
        public List<FilterTag> FilterTags { get; set; }

        /// <summary>
        /// 一次拉多少条
        /// </summary>
        [JsonProperty("max_count")]
        [XmlElement("max_count")]
        public string MaxCount { get; set; }
    }
}
