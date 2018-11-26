using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SealPosition Data Structure.
    /// </summary>
    [Serializable]
    public class SealPosition : AlipayObject
    {
        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("keyword")]
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 加盖签章页号
        /// </summary>
        [JsonProperty("page_no")]
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 类型  1 : 基于关键字定位  2 : 基于相对位置定位  3 : 默认签名区  4 : 齐缝章
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 相对于某一页的X轴偏移
        /// </summary>
        [JsonProperty("x")]
        [XmlElement("x")]
        public long X { get; set; }

        /// <summary>
        /// 相对于某一页的y轴偏移
        /// </summary>
        [JsonProperty("y")]
        [XmlElement("y")]
        public long Y { get; set; }
    }
}
