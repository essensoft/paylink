using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LocationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LocationInfo : AlipayObject
    {
        /// <summary>
        /// 用户所处的经度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 用户当前的纬度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 国家统一行政编码
        /// </summary>
        [JsonProperty("region_code")]
        public string RegionCode { get; set; }
    }
}
