using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsAddressee Data Structure.
    /// </summary>
    [Serializable]
    public class InsAddressee : AlipayObject
    {
        /// <summary>
        /// 收件人详细地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("address_code")]
        [XmlElement("address_code")]
        public string AddressCode { get; set; }

        /// <summary>
        /// 联系地址-城区
        /// </summary>
        [JsonProperty("area")]
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 联系地址-城市
        /// </summary>
        [JsonProperty("city")]
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("email")]
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 联系方式(mobile登录号)
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系地址-电话
        /// </summary>
        [JsonProperty("phone")]
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 联系地址-省份
        /// </summary>
        [JsonProperty("province")]
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 联系地址-邮编
        /// </summary>
        [JsonProperty("zip")]
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
