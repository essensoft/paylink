using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountModel Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountModel : AlipayObject
    {
        /// <summary>
        /// 每期折扣，保留小数点2位
        /// </summary>
        [JsonProperty("term_discount")]
        [XmlElement("term_discount")]
        public string TermDiscount { get; set; }

        /// <summary>
        /// 分期期次，0表示不分期，整笔折扣
        /// </summary>
        [JsonProperty("term_no")]
        [XmlElement("term_no")]
        public long TermNo { get; set; }
    }
}
