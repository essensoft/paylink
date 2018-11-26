using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCookDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCookDetailInfo : AlipayObject
    {
        /// <summary>
        /// 菜谱大类
        /// </summary>
        [JsonProperty("catetory_big_id")]
        [XmlElement("catetory_big_id")]
        public string CatetoryBigId { get; set; }

        /// <summary>
        /// 菜谱小类
        /// </summary>
        [JsonProperty("catetory_small_id")]
        [XmlElement("catetory_small_id")]
        public string CatetorySmallId { get; set; }

        /// <summary>
        /// 菜谱id
        /// </summary>
        [JsonProperty("cook_id")]
        [XmlElement("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonProperty("dish_id")]
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 打标
        /// </summary>
        [JsonProperty("flag")]
        [XmlElement("flag")]
        public string Flag { get; set; }

        /// <summary>
        /// 价格明细
        /// </summary>
        [JsonProperty("kb_cook_sku_price_list")]
        [XmlArray("kb_cook_sku_price_list")]
        [XmlArrayItem("kbdish_cook_price_info")]
        public List<KbdishCookPriceInfo> KbCookSkuPriceList { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [JsonProperty("sort")]
        [XmlElement("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
