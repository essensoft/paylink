using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BenefitInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitInfoDetail : AlipayObject
    {
        /// <summary>
        /// PRE_FUND：实际核销或者商户赠送的金额  DISCOUNT：实际折扣掉的金额（获取权益不支持该类型）  COUPON：实际核销或者商户赠送的券
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 权益类型  PRE_FUND（卡面额）  DISCOUNT：折扣金额  COUPON：券
        /// </summary>
        [JsonProperty("benefit_type")]
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// COUPON：当核销或者赠送券时，可以设置该值
        /// </summary>
        [JsonProperty("count")]
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 产生核销或者赠送权益的描述
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
