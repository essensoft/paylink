using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeResidentinfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeResidentinfoDeleteModel : AlipayObject
    {
        /// <summary>
        /// 待删除的住户所在的小区ID(支付宝平台统一小区ID标识)
        /// </summary>
        [JsonProperty("community_id")]
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 待删除住户在物业系统中的唯一标示,一次至多传入200条用户ID
        /// </summary>
        [JsonProperty("out_resident_id_set")]
        [XmlArray("out_resident_id_set")]
        [XmlArrayItem("string")]
        public List<string> OutResidentIdSet { get; set; }
    }
}
