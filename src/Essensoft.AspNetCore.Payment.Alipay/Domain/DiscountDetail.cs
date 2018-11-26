using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountDetail : AlipayObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonProperty("discount_amount")]
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 优惠描述，比如至多优惠XX元，满XX减XX
        /// </summary>
        [JsonProperty("discount_desc")]
        [XmlArray("discount_desc")]
        [XmlArrayItem("string")]
        public List<string> DiscountDesc { get; set; }

        /// <summary>
        /// 优惠类型,商家优惠（M_DISCOUNT），平台优惠（RT_DISCOUNT）
        /// </summary>
        [JsonProperty("discount_type")]
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 优惠ID或活动ID
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 优惠是否命中, true代表命中了优惠；false代表未命中优惠
        /// </summary>
        [JsonProperty("is_hit")]
        [XmlElement("is_hit")]
        public string IsHit { get; set; }

        /// <summary>
        /// 是否是购买券, true代表是购买的券，false调表不是购买的券
        /// </summary>
        [JsonProperty("is_purchased")]
        [XmlElement("is_purchased")]
        public string IsPurchased { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
