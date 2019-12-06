using System.Text.Json.Serialization;

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
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 收货地址地址码。可能对应市级，也可能对应区级
        /// </summary>
        [JsonPropertyName("address_code")]
        public string AddressCode { get; set; }

        /// <summary>
        /// 收货地址区名
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 收货地址城市名
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 收货地址经纬度
        /// </summary>
        [JsonPropertyName("coordinate")]
        public string Coordinate { get; set; }

        /// <summary>
        /// 是否默认收货地址。T：是，F：否。
        /// </summary>
        [JsonPropertyName("default_user_address")]
        public string DefaultUserAddress { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收货地址省名
        /// </summary>
        [JsonPropertyName("prov")]
        public string Prov { get; set; }
    }
}
