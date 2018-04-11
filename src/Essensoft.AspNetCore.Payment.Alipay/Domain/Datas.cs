using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Datas Data Structure.
    /// </summary>
    [Serializable]
    public class Datas : AlipayObject
    {
        /// <summary>
        /// 指标数据区
        /// </summary>
        [JsonProperty("data")]
        [XmlArray("data")]
        [XmlArrayItem("data_entry")]
        public List<DataEntry> Data { get; set; }

        /// <summary>
        /// 数据维度
        /// </summary>
        [JsonProperty("dimension")]
        [XmlArray("dimension")]
        [XmlArrayItem("data_dim")]
        public List<DataDim> Dimension { get; set; }
    }
}
