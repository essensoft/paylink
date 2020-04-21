using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Roadinter Data Structure.
    /// </summary>
    public class Roadinter : AlipayObject
    {
        /// <summary>
        /// 输入点相对路口的方位
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 交叉路口到请求坐标的距离，单位是米
        /// </summary>
        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 第一条道路id
        /// </summary>
        [JsonPropertyName("first_id")]
        public string FirstId { get; set; }

        /// <summary>
        /// 第一条道路名称
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 路口经纬度
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// 第二条道路id
        /// </summary>
        [JsonPropertyName("second_id")]
        public string SecondId { get; set; }

        /// <summary>
        /// 第二条道路名称
        /// </summary>
        [JsonPropertyName("second_name")]
        public string SecondName { get; set; }
    }
}
