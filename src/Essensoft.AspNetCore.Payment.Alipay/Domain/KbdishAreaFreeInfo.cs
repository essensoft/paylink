using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishAreaFreeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishAreaFreeInfo : AlipayObject
    {
        /// <summary>
        /// 餐区id
        /// </summary>
        [JsonProperty("area_id")]
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 份数
        /// </summary>
        [JsonProperty("count")]
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [JsonProperty("dish_id")]
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// sku_id
        /// </summary>
        [JsonProperty("dish_sku_id")]
        [XmlElement("dish_sku_id")]
        public string DishSkuId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
