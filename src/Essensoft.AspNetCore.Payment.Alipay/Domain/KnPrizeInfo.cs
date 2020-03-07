using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KnPrizeInfo Data Structure.
    /// </summary>
    public class KnPrizeInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝营销海豚奖品生效时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品结束时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品id
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品名称
        /// </summary>
        [JsonPropertyName("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品子类型
        /// </summary>
        [JsonPropertyName("prize_sub_type")]
        public string PrizeSubType { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品类型
        /// </summary>
        [JsonPropertyName("prize_type")]
        public string PrizeType { get; set; }
    }
}
