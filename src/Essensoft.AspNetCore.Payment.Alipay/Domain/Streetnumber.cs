using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Streetnumber Data Structure.
    /// </summary>
    [Serializable]
    public class Streetnumber : AlipayObject
    {
        /// <summary>
        /// 街道方向
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 门牌地址到请求坐标的距离
        /// </summary>
        [JsonProperty("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 坐标点
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 门牌号
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// 街道名称
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }
    }
}
