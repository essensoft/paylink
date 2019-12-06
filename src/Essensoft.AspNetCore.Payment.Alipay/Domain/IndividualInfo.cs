using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndividualInfo Data Structure.
    /// </summary>
    public class IndividualInfo : AlipayObject
    {
        /// <summary>
        /// 生日
        /// </summary>
        [JsonPropertyName("date_of_birth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 个人名字
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 个人居住地
        /// </summary>
        [JsonPropertyName("residential_address")]
        public string ResidentialAddress { get; set; }

        /// <summary>
        /// 该个体的类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
