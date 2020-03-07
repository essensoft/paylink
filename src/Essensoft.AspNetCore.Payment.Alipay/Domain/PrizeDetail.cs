using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrizeDetail Data Structure.
    /// </summary>
    public class PrizeDetail : AlipayObject
    {
        /// <summary>
        /// 中奖时间
        /// </summary>
        [JsonPropertyName("gmt_time")]
        public string GmtTime { get; set; }

        /// <summary>
        /// 外部奖品id（如果是券，就是券id）
        /// </summary>
        [JsonPropertyName("out_prize_id")]
        public string OutPrizeId { get; set; }

        /// <summary>
        /// 奖品价值,单位分，如支付宝优惠券等类型奖品，可能为0
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 奖品Id
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }
    }
}
