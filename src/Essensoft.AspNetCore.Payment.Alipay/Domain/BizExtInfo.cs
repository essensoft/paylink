using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizExtInfo Data Structure.
    /// </summary>
    public class BizExtInfo : AlipayObject
    {
        /// <summary>
        /// key-value
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
