using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryProvCityInfo Data Structure.
    /// </summary>
    public class QueryProvCityInfo : AlipayObject
    {
        /// <summary>
        /// 省市编号
        /// </summary>
        [JsonPropertyName("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
