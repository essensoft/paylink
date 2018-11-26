using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataItemSalesRule Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataItemSalesRule : AlipayObject
    {
        /// <summary>
        /// 购买人群限制集合，开放平台暂时不支持此字段，如果需要使用，需要评估
        /// </summary>
        [JsonProperty("buyer_crowd_limit")]
        [XmlElement("buyer_crowd_limit")]
        public string BuyerCrowdLimit { get; set; }

        /// <summary>
        /// 商品单日销售上限
        /// </summary>
        [JsonProperty("daily_sales_limit")]
        [XmlElement("daily_sales_limit")]
        public long DailySalesLimit { get; set; }

        /// <summary>
        /// 用户购买策略如不填，则默认值为一个用户一天可以领取三次。  可限制DAY、WEEK、MONTH中n天领取m次，格式为DAY|n|m；  同时也可限制券的1次生命周期中可被领取x次，如ALL|1|x，两个规则可组合使用
        /// </summary>
        [JsonProperty("user_sales_limit")]
        [XmlArray("user_sales_limit")]
        [XmlArrayItem("string")]
        public List<string> UserSalesLimit { get; set; }
    }
}
