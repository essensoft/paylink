using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CashCampaignInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CashCampaignInfo : AlipayObject
    {
        /// <summary>
        /// 活动状态
        /// </summary>
        [JsonProperty("camp_status")]
        [XmlElement("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 现金红包名称
        /// </summary>
        [JsonProperty("coupon_name")]
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 现金红包活动号
        /// </summary>
        [JsonProperty("crowd_no")]
        [XmlElement("crowd_no")]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 原始活动号,商户进行问题排查时提供
        /// </summary>
        [JsonProperty("origin_crowd_no")]
        [XmlElement("origin_crowd_no")]
        public string OriginCrowdNo { get; set; }
    }
}
