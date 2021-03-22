using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// GoodsSalesVolume Data Structure.
    /// </summary>
    public class GoodsSalesVolume : AlipayObject
    {
        /// <summary>
        /// 商品销量周期。使用枚举值 MONTH/HALF_YEAR/YEAR 分别表示月/半年/年
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 销量数值串，需要为整数
        /// </summary>
        [JsonPropertyName("volume")]
        public long Volume { get; set; }
    }
}
