using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserMailInfoOrder Data Structure.
    /// </summary>
    [Serializable]
    public class UserMailInfoOrder : AlipayObject
    {
        /// <summary>
        /// 联系所在城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 联系人国家
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// 联系人所在县/区
        /// </summary>
        [JsonProperty("county_district")]
        public string CountyDistrict { get; set; }

        /// <summary>
        /// 联系所在详细地址
        /// </summary>
        [JsonProperty("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 商户ipRole(pid)
        /// </summary>
        [JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 联系人名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系人省份
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 联系人所在街道
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }
    }
}
