using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
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
