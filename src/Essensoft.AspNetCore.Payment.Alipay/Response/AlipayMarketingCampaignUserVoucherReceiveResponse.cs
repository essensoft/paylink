using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherReceiveResponse.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 券id：领取成功时返回
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
