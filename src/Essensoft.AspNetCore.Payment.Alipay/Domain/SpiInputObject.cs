using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpiInputObject Data Structure.
    /// </summary>
    public class SpiInputObject : AlipayObject
    {
        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("age")]
        public string Age { get; set; }
    }
}
