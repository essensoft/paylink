using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回商品券集合信息
        /// </summary>
        [JsonPropertyName("items")]
        public List<PromoItemInfo> Items { get; set; }
    }
}
