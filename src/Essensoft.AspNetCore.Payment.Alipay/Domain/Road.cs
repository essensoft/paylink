using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Road Data Structure.
    /// </summary>
    [Serializable]
    public class Road : AlipayObject
    {
        /// <summary>
        /// 输入点和此路的相对方位
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 道路到请求坐标的距离
        /// </summary>
        [JsonProperty("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 道路ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 道路的中心点
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 道路名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
