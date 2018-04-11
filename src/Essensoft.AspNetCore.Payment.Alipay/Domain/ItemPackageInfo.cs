using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemPackageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPackageInfo : AlipayObject
    {
        /// <summary>
        /// 商品详情-套餐内菜品信息列表
        /// </summary>
        [JsonProperty("item_units")]
        [XmlArray("item_units")]
        [XmlArrayItem("item_unit_info")]
        public List<ItemUnitInfo> ItemUnits { get; set; }

        /// <summary>
        /// 商品详情-套餐标题。最多不超过15个汉字，30个字符
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
