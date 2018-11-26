using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserCrowdConditions Data Structure.
    /// </summary>
    [Serializable]
    public class UserCrowdConditions : AlipayObject
    {
        /// <summary>
        /// 最爱这家店的人
        /// </summary>
        [JsonProperty("crowd_group_id")]
        [XmlElement("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 用户群组描述
        /// </summary>
        [JsonProperty("describe")]
        [XmlElement("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 命中用户规则集合
        /// </summary>
        [JsonProperty("hit_crowd_conditons")]
        [XmlArray("hit_crowd_conditons")]
        [XmlArrayItem("condition_item_pattern")]
        public List<ConditionItemPattern> HitCrowdConditons { get; set; }
    }
}
