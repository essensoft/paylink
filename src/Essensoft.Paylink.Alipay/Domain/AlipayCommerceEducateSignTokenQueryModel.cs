using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSignTokenQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateSignTokenQueryModel : AlipayObject
    {
        /// <summary>
        /// 加密TOKEN
        /// </summary>
        [JsonPropertyName("token_key")]
        public string TokenKey { get; set; }
    }
}
