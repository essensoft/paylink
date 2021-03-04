using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMerchantActivityBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动详细信息
        /// </summary>
        [JsonPropertyName("activity_detail_info_list")]
        public List<MActivityDetailInfo> ActivityDetailInfoList { get; set; }
    }
}
