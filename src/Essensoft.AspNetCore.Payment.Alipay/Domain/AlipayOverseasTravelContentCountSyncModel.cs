using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelContentCountSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelContentCountSyncModel : AlipayObject
    {
        /// <summary>
        /// 计数信息列表
        /// </summary>
        [JsonProperty("count_infos")]
        [XmlArray("count_infos")]
        [XmlArrayItem("count_info")]
        public List<CountInfo> CountInfos { get; set; }
    }
}
