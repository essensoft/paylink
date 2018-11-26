using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecruitItemApplyData Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitItemApplyData : AlipayObject
    {
        /// <summary>
        /// 活动价格，单位为元，活动期间以此价格售卖。注：预热期间仍然以原价售卖，但是不消耗活动的库存。
        /// </summary>
        [JsonProperty("activity_price")]
        [XmlElement("activity_price")]
        public string ActivityPrice { get; set; }

        /// <summary>
        /// 活动总库存，活动锁定的库存，是从商品总库存中隔离出来的库存。只有活动期间购买商品会消耗活动库存。
        /// </summary>
        [JsonProperty("activity_stock")]
        [XmlElement("activity_stock")]
        public string ActivityStock { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("item_id")]
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品原价，单位为元
        /// </summary>
        [JsonProperty("original_price")]
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 折扣，8.5表示八五折，9表示九折
        /// </summary>
        [JsonProperty("sales")]
        [XmlElement("sales")]
        public string Sales { get; set; }
    }
}
