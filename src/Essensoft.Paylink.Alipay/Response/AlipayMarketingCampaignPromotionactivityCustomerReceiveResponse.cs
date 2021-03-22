using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityCustomerReceiveResponse.
    /// </summary>
    public class AlipayMarketingCampaignPromotionactivityCustomerReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 券模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
