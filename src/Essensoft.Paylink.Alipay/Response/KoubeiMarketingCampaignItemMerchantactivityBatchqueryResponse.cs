using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [JsonPropertyName("activities")]
        public List<MerchantOnlineActivityOpenModel> Activities { get; set; }
    }
}
