using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommodityExtInfoConfirm Data Structure.
    /// </summary>
    [Serializable]
    public class CommodityExtInfoConfirm : AlipayObject
    {
        /// <summary>
        /// 城市上架结果 【 0：表示失败，  1：表示成功】
        /// </summary>
        [JsonProperty("city_status")]
        [XmlElement("city_status")]
        public string CityStatus { get; set; }

        /// <summary>
        /// 挂载ID，用于确认唯一记录的主键对象
        /// </summary>
        [JsonProperty("displayapp_id")]
        [XmlElement("displayapp_id")]
        public string DisplayappId { get; set; }

        /// <summary>
        /// 修改城市记录映射对应的原有的挂载id,如果原有服务没有上架城市，该参数为空
        /// </summary>
        [JsonProperty("mapping_displayapp_id")]
        [XmlElement("mapping_displayapp_id")]
        public string MappingDisplayappId { get; set; }

        /// <summary>
        /// 城市上架失败原因
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
