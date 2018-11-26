using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountRandomModel Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountRandomModel : AlipayObject
    {
        /// <summary>
        /// 最高优惠金额
        /// </summary>
        [JsonProperty("max_amount")]
        [XmlElement("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 最低优惠金额
        /// </summary>
        [JsonProperty("min_amount")]
        [XmlElement("min_amount")]
        public string MinAmount { get; set; }

        /// <summary>
        /// 概率 金额区间、占比支持小数点后两位  区间为前闭、后闭，最多可以设置10种金额区间，所有区间占比和需要等于100%
        /// </summary>
        [JsonProperty("probability")]
        [XmlElement("probability")]
        public string Probability { get; set; }
    }
}
