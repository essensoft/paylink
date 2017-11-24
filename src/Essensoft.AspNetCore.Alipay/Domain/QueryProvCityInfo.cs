using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// QueryProvCityInfo Data Structure.
    /// </summary>
    public class QueryProvCityInfo : AlipayObject
    {
        /// <summary>
        /// 省市编号
        /// </summary>
        [JsonProperty("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
