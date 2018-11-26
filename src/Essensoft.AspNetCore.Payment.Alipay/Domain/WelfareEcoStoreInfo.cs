using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WelfareEcoStoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WelfareEcoStoreInfo : AlipayObject
    {
        /// <summary>
        /// 门店具体位置（中文）
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonProperty("brand")]
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
