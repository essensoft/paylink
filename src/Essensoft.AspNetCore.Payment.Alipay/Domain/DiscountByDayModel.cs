using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountByDayModel Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountByDayModel : AlipayObject
    {
        /// <summary>
        /// 开始天数，最小为1
        /// </summary>
        [JsonProperty("begin_day")]
        [XmlElement("begin_day")]
        public long BeginDay { get; set; }

        /// <summary>
        /// 相对折扣，保留小数点2位
        /// </summary>
        [JsonProperty("discount")]
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 结束天数
        /// </summary>
        [JsonProperty("end_day")]
        [XmlElement("end_day")]
        public long EndDay { get; set; }
    }
}
