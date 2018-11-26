using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDiscountDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PosDiscountDetail : AlipayObject
    {
        /// <summary>
        /// 优惠名称
        /// </summary>
        [JsonProperty("discount_name")]
        [XmlElement("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [JsonProperty("discount_type")]
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 扩展信息，存储优惠的详细模型。json对象格式，key和value都为字符串
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商家出资优惠金额，以元为单位，精确到分
        /// </summary>
        [JsonProperty("mrt_discount")]
        [XmlElement("mrt_discount")]
        public string MrtDiscount { get; set; }

        /// <summary>
        /// 平台出资优惠金额，以元为单位，精确到分
        /// </summary>
        [JsonProperty("rt_discount")]
        [XmlElement("rt_discount")]
        public string RtDiscount { get; set; }
    }
}
