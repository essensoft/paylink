using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// POIinfo Data Structure.
    /// </summary>
    [Serializable]
    public class POIinfo : AlipayObject
    {
        /// <summary>
        /// poi地址信息
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// POI所在商圈名称
        /// </summary>
        [JsonProperty("businessarea")]
        public string Businessarea { get; set; }

        /// <summary>
        /// 输入点相对POI的方位
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 该POI到请求坐标的距离
        /// </summary>
        [JsonProperty("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// POI的id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// POI中心点的坐标
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// POI名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonProperty("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// POI的类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
