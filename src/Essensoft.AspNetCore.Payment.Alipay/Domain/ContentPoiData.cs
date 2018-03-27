using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentPoiData Data Structure.
    /// </summary>
    public class ContentPoiData : AlipayObject
    {
        /// <summary>
        /// poi纬度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// poi经度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 位置信息
        /// </summary>
        [JsonProperty("poi_name")]
        public string PoiName { get; set; }
    }
}
