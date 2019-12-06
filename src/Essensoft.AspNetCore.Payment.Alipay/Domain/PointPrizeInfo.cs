using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PointPrizeInfo Data Structure.
    /// </summary>
    public class PointPrizeInfo : AlipayObject
    {
        /// <summary>
        /// 奖品兑换的结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 兑换奖品所需的积分数，大于0
        /// </summary>
        [JsonPropertyName("exchange_point")]
        public long ExchangePoint { get; set; }

        /// <summary>
        /// 奖品的发放使用规则说明等
        /// </summary>
        [JsonPropertyName("intro")]
        public string Intro { get; set; }

        /// <summary>
        /// 奖品图片地址
        /// </summary>
        [JsonPropertyName("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 积分奖品名称
        /// </summary>
        [JsonPropertyName("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品编号
        /// </summary>
        [JsonPropertyName("prize_no")]
        public string PrizeNo { get; set; }

        /// <summary>
        /// 奖品类型。CONSUME_VOUCHER：消费红包，IN_KIND_PRIZE：实物奖品。全部类型可在财富开放平台查看
        /// </summary>
        [JsonPropertyName("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 奖品开始兑换的时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 奖品库存，当前剩余可兑换的库存
        /// </summary>
        [JsonPropertyName("stock")]
        public long Stock { get; set; }
    }
}
