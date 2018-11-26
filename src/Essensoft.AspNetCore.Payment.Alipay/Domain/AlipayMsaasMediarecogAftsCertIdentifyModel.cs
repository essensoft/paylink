using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsCertIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAftsCertIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 扩展入参
        /// </summary>
        [JsonProperty("ext")]
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 高
        /// </summary>
        [JsonProperty("h")]
        [XmlElement("h")]
        public long H { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("plate_number")]
        [XmlElement("plate_number")]
        public string PlateNumber { get; set; }

        /// <summary>
        /// 传入资源URL或djangoid或aftsid
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        [JsonProperty("w")]
        [XmlElement("w")]
        public long W { get; set; }

        /// <summary>
        /// 左上角x
        /// </summary>
        [JsonProperty("x")]
        [XmlElement("x")]
        public long X { get; set; }

        /// <summary>
        /// 左上角y
        /// </summary>
        [JsonProperty("y")]
        [XmlElement("y")]
        public long Y { get; set; }
    }
}
