using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAddressQueryResponse.
    /// </summary>
    public class AlipayUserAddressQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 地址详情
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 收货地址地址码。可能对应市级，也可能对应区级
        /// </summary>
        [JsonProperty("address_code")]
        [XmlElement("address_code")]
        public string AddressCode { get; set; }

        /// <summary>
        /// 收货地址区名
        /// </summary>
        [JsonProperty("area")]
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 收货地址城市名
        /// </summary>
        [JsonProperty("city")]
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 收货地址经纬度
        /// </summary>
        [JsonProperty("coordinate")]
        [XmlElement("coordinate")]
        public string Coordinate { get; set; }

        /// <summary>
        /// 是否默认收货地址。T：是，F：否。
        /// </summary>
        [JsonProperty("default_user_address")]
        [XmlElement("default_user_address")]
        public string DefaultUserAddress { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [JsonProperty("fullname")]
        [XmlElement("fullname")]
        public string Fullname { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收货地址省名
        /// </summary>
        [JsonProperty("prov")]
        [XmlElement("prov")]
        public string Prov { get; set; }
    }
}
