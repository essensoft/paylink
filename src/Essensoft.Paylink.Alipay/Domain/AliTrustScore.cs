using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AliTrustScore Data Structure.
    /// </summary>
    public class AliTrustScore : AlipayObject
    {
        /// <summary>
        /// 芝麻分
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }
    }
}
