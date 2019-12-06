using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PricingVO Data Structure.
    /// </summary>
    public class PricingVO : AlipayObject
    {
        /// <summary>
        /// 买入价
        /// </summary>
        [JsonPropertyName("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 基准币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 基本币种单位
        /// </summary>
        [JsonPropertyName("currency_unit")]
        public long CurrencyUnit { get; set; }

        /// <summary>
        /// 汇率失效时间yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("expiry_timestamp")]
        public string ExpiryTimestamp { get; set; }

        /// <summary>
        /// 汇率生成时间 用来做幂等 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("generate_timestamp")]
        public string GenerateTimestamp { get; set; }

        /// <summary>
        /// 远期或者掉期到期时间 yyyyMMdd
        /// </summary>
        [JsonPropertyName("maturity_date")]
        public string MaturityDate { get; set; }

        /// <summary>
        /// 该价格的最大买入量
        /// </summary>
        [JsonPropertyName("maximum_bid_amount")]
        public long MaximumBidAmount { get; set; }

        /// <summary>
        /// 该价格的最大卖出量
        /// </summary>
        [JsonPropertyName("maximum_offer_amount")]
        public long MaximumOfferAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 中间价
        /// </summary>
        [JsonPropertyName("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 该价格的最小买入量
        /// </summary>
        [JsonPropertyName("minimum_bid_amount")]
        public long MinimumBidAmount { get; set; }

        /// <summary>
        /// 该价格的最小卖出量
        /// </summary>
        [JsonPropertyName("minimum_offer_amount")]
        public long MinimumOfferAmount { get; set; }

        /// <summary>
        /// 卖出价
        /// </summary>
        [JsonPropertyName("offer")]
        public string Offer { get; set; }

        /// <summary>
        /// 标准期限TODAY TOM SPOT 1D 1W 1M 1Y
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 源汇率参考id 唯一id
        /// </summary>
        [JsonPropertyName("rate_reference_id")]
        public string RateReferenceId { get; set; }

        /// <summary>
        /// 汇率类型 SPOT FORWARD
        /// </summary>
        [JsonPropertyName("rate_type")]
        public string RateType { get; set; }

        /// <summary>
        /// 即期买入价
        /// </summary>
        [JsonPropertyName("spot_bid")]
        public string SpotBid { get; set; }

        /// <summary>
        /// 即期中间价
        /// </summary>
        [JsonPropertyName("spot_mid")]
        public string SpotMid { get; set; }

        /// <summary>
        /// 即期卖出价
        /// </summary>
        [JsonPropertyName("spot_offer")]
        public string SpotOffer { get; set; }

        /// <summary>
        /// 汇率生效时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_timestamp")]
        public string StartTimestamp { get; set; }

        /// <summary>
        /// 货币对
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// 汇率缓冲时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("threshold_timestamp")]
        public string ThresholdTimestamp { get; set; }

        /// <summary>
        /// 锁汇失效时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("valid_timestamp")]
        public string ValidTimestamp { get; set; }
    }
}
