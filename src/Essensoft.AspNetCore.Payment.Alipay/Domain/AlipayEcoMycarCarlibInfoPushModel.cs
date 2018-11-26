using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarCarlibInfoPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCarlibInfoPushModel : AlipayObject
    {
        /// <summary>
        /// 品牌
        /// </summary>
        [JsonProperty("brand")]
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [JsonProperty("cc")]
        [XmlElement("cc")]
        public string Cc { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonProperty("company")]
        [XmlElement("company")]
        public string Company { get; set; }

        /// <summary>
        /// 发动机型号
        /// </summary>
        [JsonProperty("engine")]
        [XmlElement("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// 销售名字
        /// </summary>
        [JsonProperty("marker")]
        [XmlElement("marker")]
        public string Marker { get; set; }

        /// <summary>
        /// 生产年份
        /// </summary>
        [JsonProperty("prod_year")]
        [XmlElement("prod_year")]
        public string ProdYear { get; set; }

        /// <summary>
        /// 车系
        /// </summary>
        [JsonProperty("serie")]
        [XmlElement("serie")]
        public string Serie { get; set; }

        /// <summary>
        /// 车款
        /// </summary>
        [JsonProperty("style")]
        [XmlElement("style")]
        public string Style { get; set; }
    }
}
