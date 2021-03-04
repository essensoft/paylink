using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SpiOutputObject Data Structure.
    /// </summary>
    public class SpiOutputObject : AlipayObject
    {
        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("age")]
        public string Age { get; set; }
    }
}
