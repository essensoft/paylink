using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AddressDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AddressDTO : AlipayObject
    {
        /// <summary>
        /// POI编码
        /// </summary>
        [JsonProperty("poi_code")]
        public string PoiCode { get; set; }

        /// <summary>
        /// POI访问URL
        /// </summary>
        [JsonProperty("poi_url")]
        public string PoiUrl { get; set; }
    }
}
