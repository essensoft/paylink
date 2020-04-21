using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignWarmcardQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignWarmcardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否领过暖心卡
        /// </summary>
        [JsonPropertyName("has_receive")]
        public bool HasReceive { get; set; }

        /// <summary>
        /// 暖心卡优惠券对应是否有剩余金额标识
        /// </summary>
        [JsonPropertyName("voucher_type_remain_info")]
        public string VoucherTypeRemainInfo { get; set; }
    }
}
