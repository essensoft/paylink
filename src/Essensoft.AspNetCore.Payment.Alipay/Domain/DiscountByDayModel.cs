using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountByDayModel Data Structure.
    /// </summary>
    public class DiscountByDayModel : AlipayObject
    {
        /// <summary>
        /// 开始天数，最小为1
        /// </summary>
        [JsonPropertyName("begin_day")]
        public long BeginDay { get; set; }

        /// <summary>
        /// 相对折扣，保留小数点2位
        /// </summary>
        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 结束天数
        /// </summary>
        [JsonPropertyName("end_day")]
        public long EndDay { get; set; }
    }
}
