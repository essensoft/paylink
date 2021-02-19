using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 券详情列表
        /// </summary>
        [JsonPropertyName("vouchers")]
        public List<VoucherDetailVO> Vouchers { get; set; }
    }
}
