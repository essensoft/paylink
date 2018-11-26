using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishGroupDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishGroupDetailInfo : AlipayObject
    {
        /// <summary>
        /// 组下明细的加价单价 例如加2元 加3元
        /// </summary>
        [JsonProperty("add_price")]
        [XmlElement("add_price")]
        public string AddPrice { get; set; }

        /// <summary>
        /// 明细菜品在套餐里的个数,
        /// </summary>
        [JsonProperty("detail_count")]
        [XmlElement("detail_count")]
        public string DetailCount { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonProperty("detail_dish_id")]
        [XmlElement("detail_dish_id")]
        public string DetailDishId { get; set; }

        /// <summary>
        /// 组下面的菜品是否默认 Y/N
        /// </summary>
        [JsonProperty("detail_is_default")]
        [XmlElement("detail_is_default")]
        public string DetailIsDefault { get; set; }

        /// <summary>
        /// 分组下包含的明细菜品的dish_code
        /// </summary>
        [JsonProperty("detail_sku_id")]
        [XmlElement("detail_sku_id")]
        public string DetailSkuId { get; set; }

        /// <summary>
        /// 排序字典
        /// </summary>
        [JsonProperty("detail_sort")]
        [XmlElement("detail_sort")]
        public string DetailSort { get; set; }

        /// <summary>
        /// 组id
        /// </summary>
        [JsonProperty("group_id")]
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
