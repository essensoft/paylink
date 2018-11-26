using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LawsuitPersonRecord Data Structure.
    /// </summary>
    [Serializable]
    public class LawsuitPersonRecord : AlipayObject
    {
        /// <summary>
        /// 曝光台列表
        /// </summary>
        [JsonProperty("bgt_list")]
        [XmlArray("bgt_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> BgtList { get; set; }

        /// <summary>
        /// 裁判文书列表
        /// </summary>
        [JsonProperty("cpws_list")]
        [XmlArray("cpws_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> CpwsList { get; set; }

        /// <summary>
        /// 失信公告列表
        /// </summary>
        [JsonProperty("sxgg_list")]
        [XmlArray("sxgg_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> SxggList { get; set; }

        /// <summary>
        /// 执行公告列表
        /// </summary>
        [JsonProperty("zxgg_list")]
        [XmlArray("zxgg_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> ZxggList { get; set; }
    }
}
