using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserMailInfoOrder Data Structure.
    /// </summary>
    public class UserMailInfoOrder : AlipayObject
    {
        /// <summary>
        /// 联系所在城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 联系人国家
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 联系人所在县/区
        /// </summary>
        [JsonPropertyName("county_district")]
        public string CountyDistrict { get; set; }

        /// <summary>
        /// 联系所在详细地址
        /// </summary>
        [JsonPropertyName("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 商户ipRole(pid)
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 联系人名字
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系人省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 联系人所在街道
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }
    }
}
