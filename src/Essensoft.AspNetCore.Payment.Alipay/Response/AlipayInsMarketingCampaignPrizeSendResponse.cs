using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsMarketingCampaignPrizeSendResponse.
    /// </summary>
    public class AlipayInsMarketingCampaignPrizeSendResponse : AlipayResponse
    {
        /// <summary>
        /// 资产Id，如单品券权益类型，则对应的资产Id即为券Id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 活动Id
        /// </summary>
        [JsonPropertyName("compaign_id")]
        public string CompaignId { get; set; }

        /// <summary>
        /// 用户权益Id
        /// </summary>
        [JsonPropertyName("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型：  single_voucher：单品券  full_jfb：集分宝
        /// </summary>
        [JsonPropertyName("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益值，如优惠券则表示金额
        /// </summary>
        [JsonPropertyName("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 发奖流水Id
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }
    }
}
