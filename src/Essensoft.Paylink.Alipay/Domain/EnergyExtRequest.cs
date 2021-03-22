using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// EnergyExtRequest Data Structure.
    /// </summary>
    public class EnergyExtRequest : AlipayObject
    {
        /// <summary>
        /// 扩展信息的key信息
        /// </summary>
        [JsonPropertyName("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 扩展信息的value信息
        /// </summary>
        [JsonPropertyName("ext_value")]
        public string ExtValue { get; set; }
    }
}
