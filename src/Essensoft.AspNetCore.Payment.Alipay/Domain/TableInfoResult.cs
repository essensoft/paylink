using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TableInfoResult Data Structure.
    /// </summary>
    [Serializable]
    public class TableInfoResult : AlipayObject
    {
        /// <summary>
        /// 返回TableListResult集合
        /// </summary>
        [JsonProperty("table_info_list")]
        [XmlArray("table_info_list")]
        [XmlArrayItem("table_list_result")]
        public List<TableListResult> TableInfoList { get; set; }
    }
}
