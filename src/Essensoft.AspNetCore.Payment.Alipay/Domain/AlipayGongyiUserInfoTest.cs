using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayGongyiUserInfoTest Data Structure.
    /// </summary>
    public class AlipayGongyiUserInfoTest : AlipayObject
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [JsonPropertyName("address")]
        public AlipayGongyiAddressTest Address { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [JsonPropertyName("age")]
        public long Age { get; set; }

        /// <summary>
        /// 1912-12-12
        /// </summary>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 上海，杭州
        /// </summary>
        [JsonPropertyName("citys")]
        public List<string> Citys { get; set; }

        /// <summary>
        /// 1001
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// zhangsan
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 学校地址列表
        /// </summary>
        [JsonPropertyName("school_list")]
        public List<AlipayGongyiAddressTest> SchoolList { get; set; }
    }
}
