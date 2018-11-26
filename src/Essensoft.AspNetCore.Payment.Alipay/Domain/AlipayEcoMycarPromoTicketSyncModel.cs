using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarPromoTicketSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarPromoTicketSyncModel : AlipayObject
    {
        /// <summary>
        /// 营销活动ID
        /// </summary>
        [JsonProperty("active_id")]
        [XmlElement("active_id")]
        public string ActiveId { get; set; }

        /// <summary>
        /// 需要同步的卡券信息
        /// </summary>
        [JsonProperty("code_no_list")]
        [XmlArray("code_no_list")]
        [XmlArrayItem("code_n_o_list")]
        public List<CodeNOList> CodeNoList { get; set; }

        /// <summary>
        /// 卡券来源
        /// </summary>
        [JsonProperty("source_type")]
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
