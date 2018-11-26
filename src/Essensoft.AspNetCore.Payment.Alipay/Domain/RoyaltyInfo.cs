using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RoyaltyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyInfo : AlipayObject
    {
        /// <summary>
        /// 分账明细的信息，可以描述多条分账指令，json数组。
        /// </summary>
        [JsonProperty("royalty_detail_infos")]
        [XmlArray("royalty_detail_infos")]
        [XmlArrayItem("royalty_detail_infos")]
        public List<RoyaltyDetailInfos> RoyaltyDetailInfos { get; set; }

        /// <summary>
        /// 分账类型  卖家的分账类型，目前只支持传入ROYALTY（普通分账类型）。
        /// </summary>
        [JsonProperty("royalty_type")]
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }
    }
}
