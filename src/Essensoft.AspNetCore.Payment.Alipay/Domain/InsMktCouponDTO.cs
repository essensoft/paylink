using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktCouponDTO Data Structure.
    /// </summary>
    public class InsMktCouponDTO : AlipayObject
    {
        /// <summary>
        /// 权益资产Id，如券Id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 权益Id
        /// </summary>
        [JsonPropertyName("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonPropertyName("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 500元单品券
        /// </summary>
        [JsonPropertyName("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 是否推荐使用该优惠
        /// </summary>
        [JsonPropertyName("recommend")]
        public bool Recommend { get; set; }

        /// <summary>
        /// 核销结束时间
        /// </summary>
        [JsonPropertyName("use_end_time")]
        public string UseEndTime { get; set; }

        /// <summary>
        /// 核销规则
        /// </summary>
        [JsonPropertyName("use_rule")]
        public string UseRule { get; set; }

        /// <summary>
        /// 核销开始时间
        /// </summary>
        [JsonPropertyName("use_start_time")]
        public string UseStartTime { get; set; }
    }
}
