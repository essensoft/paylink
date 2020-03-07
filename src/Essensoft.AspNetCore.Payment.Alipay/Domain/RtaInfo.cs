using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RtaInfo Data Structure.
    /// </summary>
    public class RtaInfo : AlipayObject
    {
        /// <summary>
        /// 广告投放账户id
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }
    }
}
