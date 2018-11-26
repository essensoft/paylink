using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainDataUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainDataUpdateModel : AlipayObject
    {
        /// <summary>
        /// 门店或者服务的编码
        /// </summary>
        [JsonProperty("biz_id")]
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 事件类型(1:上下线 2:服务价格)
        /// </summary>
        [JsonProperty("event_id")]
        [XmlElement("event_id")]
        public long EventId { get; set; }

        /// <summary>
        /// 来源(1:汽车超人)
        /// </summary>
        [JsonProperty("source")]
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 类型(1:门店 2:服务)
        /// </summary>
        [JsonProperty("type_id")]
        [XmlElement("type_id")]
        public string TypeId { get; set; }
    }
}
