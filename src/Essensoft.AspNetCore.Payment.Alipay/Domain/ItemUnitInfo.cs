using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemUnitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUnitInfo : AlipayObject
    {
        /// <summary>
        /// 商品详情-商品套餐内容-菜品数量
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品价格。字符串，单位元，两位小数
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品规格
        /// </summary>
        [JsonProperty("spec")]
        [XmlElement("spec")]
        public string Spec { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品名称。不得超过15个中文字符
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品数量单位
        /// </summary>
        [JsonProperty("unit")]
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
