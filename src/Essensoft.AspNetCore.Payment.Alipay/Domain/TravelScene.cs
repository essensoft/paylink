using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TravelScene Data Structure.
    /// </summary>
    [Serializable]
    public class TravelScene : AlipayObject
    {
        /// <summary>
        /// 出行场景，综合体入参列表
        /// </summary>
        [JsonProperty("data_list")]
        [XmlArray("data_list")]
        [XmlArrayItem("travel_mall_request")]
        public List<TravelMallRequest> DataList { get; set; }
    }
}
