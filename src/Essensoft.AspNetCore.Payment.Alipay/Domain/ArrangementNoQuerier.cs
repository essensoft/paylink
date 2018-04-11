using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementNoQuerier Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementNoQuerier : AlipayObject
    {
        /// <summary>
        /// 合约编号列表
        /// </summary>
        [JsonProperty("ar_nos")]
        [XmlArray("ar_nos")]
        [XmlArrayItem("string")]
        public List<string> ArNos { get; set; }
    }
}
