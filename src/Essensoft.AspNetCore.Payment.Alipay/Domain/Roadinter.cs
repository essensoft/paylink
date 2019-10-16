using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Roadinter Data Structure.
    /// </summary>
    [Serializable]
    public class Roadinter : AlipayObject
    {
        /// <summary>
        /// 输入点相对路口的方位
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 交叉路口到请求坐标的距离，单位是米
        /// </summary>
        [JsonProperty("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 第一条道路id
        /// </summary>
        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        /// <summary>
        /// 第一条道路名称
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 路口经纬度
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 第二条道路id
        /// </summary>
        [JsonProperty("second_id")]
        public string SecondId { get; set; }

        /// <summary>
        /// 第二条道路名称
        /// </summary>
        [JsonProperty("second_name")]
        public string SecondName { get; set; }
    }
}
