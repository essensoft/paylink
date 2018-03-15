using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignVoucherDetailQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignVoucherDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonProperty("voucher_id")]
        public string VoucherId { get; set; }
    }
}
