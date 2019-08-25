using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrizeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeDetail : AlipayObject
    {
        /// <summary>
        /// 中奖时间
        /// </summary>
        [JsonProperty("gmt_time")]
        public string GmtTime { get; set; }

        /// <summary>
        /// 外部奖品id（如果是券，就是券id）
        /// </summary>
        [JsonProperty("out_prize_id")]
        public string OutPrizeId { get; set; }

        /// <summary>
        /// 奖品价值,单位分，如支付宝优惠券等类型奖品，可能为0
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 奖品Id
        /// </summary>
        [JsonProperty("prize_id")]
        public string PrizeId { get; set; }
    }
}
