using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PortfolioShop Data Structure.
    /// </summary>
    [Serializable]
    public class PortfolioShop : AlipayObject
    {
        /// <summary>
        /// 展示权重；必须大于等于0；排序规则：权重倒叙
        /// </summary>
        [JsonProperty("display_weight")]
        [XmlElement("display_weight")]
        public long DisplayWeight { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
