using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LotteryType Data Structure.
    /// </summary>
    [Serializable]
    public class LotteryType : AlipayObject
    {
        /// <summary>
        /// 彩种ID
        /// </summary>
        [JsonProperty("lottery_type_id")]
        [XmlElement("lottery_type_id")]
        public long LotteryTypeId { get; set; }

        /// <summary>
        /// 彩种名称
        /// </summary>
        [JsonProperty("lottery_type_name")]
        [XmlElement("lottery_type_name")]
        public string LotteryTypeName { get; set; }
    }
}
