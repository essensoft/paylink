using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardDomainVO Data Structure.
    /// </summary>
    public class CardDomainVO : AlipayObject
    {
        /// <summary>
        /// 值域域名的描述值，固定为”金融”
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 值域域名，固定为“FINANCE”
        /// </summary>
        [JsonPropertyName("domain_name")]
        public string DomainName { get; set; }
    }
}
