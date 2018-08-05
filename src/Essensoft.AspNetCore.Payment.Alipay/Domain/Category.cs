using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Category Data Structure.
    /// </summary>
    [Serializable]
    public class Category : AlipayObject
    {
        /// <summary>
        /// 店铺分类ID集合
        /// </summary>
        [JsonProperty("shop_cate_ids")]
        [XmlArray("shop_cate_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopCateIds { get; set; }

        /// <summary>
        /// 美食/娱乐等分类条目
        /// </summary>
        [JsonProperty("shop_cate_name")]
        [XmlElement("shop_cate_name")]
        public string ShopCateName { get; set; }
    }
}
