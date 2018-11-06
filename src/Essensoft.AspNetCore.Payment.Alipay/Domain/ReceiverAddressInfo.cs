using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReceiverAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiverAddressInfo : AlipayObject
    {
        /// <summary>
        /// 收货地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 中国标准城市区域码
        /// </summary>
        [JsonProperty("division_code")]
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收货人的姓名
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收货地址邮编
        /// </summary>
        [JsonProperty("zip")]
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
