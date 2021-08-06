using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InsurancePersonInfo Data Structure.
    /// </summary>
    public class InsurancePersonInfo : AlipayObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("card_code")]
        public string CardCode { get; set; }

        /// <summary>
        /// 投保人证件类型 01-居民身份证 03-营业执照
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [JsonPropertyName("contact_info")]
        public string ContactInfo { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
