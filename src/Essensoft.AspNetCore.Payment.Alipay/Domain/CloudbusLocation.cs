using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusLocation Data Structure.
    /// </summary>
    public class CloudbusLocation : AlipayObject
    {
        /// <summary>
        /// 维度
        /// </summary>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("lng")]
        public string Lng { get; set; }
    }
}
