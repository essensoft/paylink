using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PersonalityInfoDTO Data Structure.
    /// </summary>
    public class PersonalityInfoDTO : AlipayObject
    {
        /// <summary>
        /// 枚举名code
        /// </summary>
        [JsonPropertyName("enum_code")]
        public string EnumCode { get; set; }

        /// <summary>
        /// 枚举ID
        /// </summary>
        [JsonPropertyName("enum_id")]
        public string EnumId { get; set; }

        /// <summary>
        /// 枚举名称
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; }

        /// <summary>
        /// 枚举值code
        /// </summary>
        [JsonPropertyName("enum_value_code")]
        public string EnumValueCode { get; set; }

        /// <summary>
        /// 枚举值名称
        /// </summary>
        [JsonPropertyName("enum_value_name")]
        public string EnumValueName { get; set; }
    }
}
