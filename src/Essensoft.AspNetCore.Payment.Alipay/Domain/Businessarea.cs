using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Businessarea Data Structure.
    /// </summary>
    [Serializable]
    public class Businessarea : AlipayObject
    {
        /// <summary>
        /// 商圈所在区域的adcode
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商圈中心点经纬度
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
