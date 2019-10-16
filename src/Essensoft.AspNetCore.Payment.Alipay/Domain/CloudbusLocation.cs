using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusLocation Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusLocation : AlipayObject
    {
        /// <summary>
        /// 维度
        /// </summary>
        [JsonProperty("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("lng")]
        public string Lng { get; set; }
    }
}
