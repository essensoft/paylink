using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Streetnumber Data Structure.
    /// </summary>
    public class Streetnumber : AlipayObject
    {
        /// <summary>
        /// 街道方向
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 门牌地址到请求坐标的距离
        /// </summary>
        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 坐标点
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// 门牌号
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// 街道名称
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }
    }
}
