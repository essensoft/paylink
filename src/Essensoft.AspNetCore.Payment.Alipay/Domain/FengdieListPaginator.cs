using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieListPaginator Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieListPaginator : AlipayObject
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("page_count")]
        [XmlElement("page_count")]
        public long PageCount { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("page_number")]
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页显示记录数
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 符合条件的记录总数
        /// </summary>
        [JsonProperty("total")]
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
