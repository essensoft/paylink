using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MyObjectDdd Data Structure.
    /// </summary>
    public class MyObjectDdd : AlipayObject
    {
        /// <summary>
        /// xx
        /// </summary>
        [JsonPropertyName("item")]
        public string Item { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonPropertyName("param")]
        public string Param { get; set; }
    }
}
