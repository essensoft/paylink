using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishEstimatedSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishEstimatedSyncModel : AlipayObject
    {
        /// <summary>
        /// 菜品估清类型,estimated表示菜品估清
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 菜品估清对象列表
        /// </summary>
        [JsonProperty("kbdish_estimated_list")]
        [XmlArray("kbdish_estimated_list")]
        [XmlArrayItem("kbdish_estimated_info")]
        public List<KbdishEstimatedInfo> KbdishEstimatedList { get; set; }

        /// <summary>
        /// 同步类型,update会覆盖更新
        /// </summary>
        [JsonProperty("syn_type")]
        [XmlElement("syn_type")]
        public string SynType { get; set; }
    }
}
