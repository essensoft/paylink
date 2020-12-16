using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSelfVoucherQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignSelfVoucherQueryModel : AlipayObject
    {
        /// <summary>
        /// 券ID(券唯一标识, 发券接口返回参数)
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
