using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReportDataItem Data Structure.
    /// </summary>
    [Serializable]
    public class ReportDataItem : AlipayObject
    {
        /// <summary>
        /// 表示一行数据，每个对象是一列的数据
        /// </summary>
        [JsonProperty("row_data")]
        [XmlElement("row_data")]
        public string RowData { get; set; }
    }
}
