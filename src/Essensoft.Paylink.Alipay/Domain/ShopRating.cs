using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ShopRating Data Structure.
    /// </summary>
    public class ShopRating : AlipayObject
    {
        /// <summary>
        /// 店铺评分下限,必须为0~1000的整数
        /// </summary>
        [JsonPropertyName("lower_bound")]
        public string LowerBound { get; set; }

        /// <summary>
        /// 店铺评分上线，必须为0~1000的整数
        /// </summary>
        [JsonPropertyName("upper_bound")]
        public string UpperBound { get; set; }

        /// <summary>
        /// 当前店铺评分,为0~1000内的值。 可保留一位小数
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
