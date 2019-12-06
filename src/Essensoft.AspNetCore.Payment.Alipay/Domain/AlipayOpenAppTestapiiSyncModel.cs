using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppTestapiiSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenAppTestapiiSyncModel : AlipayObject
    {
        /// <summary>
        /// v
        /// </summary>
        [JsonPropertyName("in_1")]
        public string In1 { get; set; }

        /// <summary>
        /// b
        /// </summary>
        [JsonPropertyName("in_2")]
        public string In2 { get; set; }
    }
}
