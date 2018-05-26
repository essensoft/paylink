using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizListDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizListDataInfo : AlipayObject
    {
        /// <summary>
        /// 下拉列表编号
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 下拉列表名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
