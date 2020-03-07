using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktPreUseCouponDTO Data Structure.
    /// </summary>
    public class InsMktPreUseCouponDTO : AlipayObject
    {
        /// <summary>
        /// 资产Id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 权益id
        /// </summary>
        [JsonPropertyName("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonPropertyName("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [JsonPropertyName("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 是否支持预核销
        /// </summary>
        [JsonPropertyName("pre_use")]
        public bool PreUse { get; set; }

        /// <summary>
        /// 预核销失败原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
