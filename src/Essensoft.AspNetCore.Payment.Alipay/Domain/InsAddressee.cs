using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsAddressee Data Structure.
    /// </summary>
    public class InsAddressee : AlipayObject
    {
        /// <summary>
        /// 收件人详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonPropertyName("address_code")]
        public string AddressCode { get; set; }

        /// <summary>
        /// 联系地址-城区
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 联系地址-城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 联系方式(mobile登录号)
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系地址-电话
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 联系地址-省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 联系地址-邮编
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }
    }
}
