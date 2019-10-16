using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMapGeocodingReverseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMapGeocodingReverseModel : AlipayObject
    {
        /// <summary>
        /// 渠道 0-高德地图 1-百度地图
        /// </summary>
        [JsonProperty("channel")]
        public long Channel { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }
}
