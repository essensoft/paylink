using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignOrderVoucherConsultResponse.
    /// </summary>
    public class AlipayMarketingCampaignOrderVoucherConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 最优券叠加总优惠金额，单位为元
        /// </summary>
        [JsonPropertyName("optimal_total_promo_amount")]
        public string OptimalTotalPromoAmount { get; set; }

        /// <summary>
        /// 优惠券咨询结果列表
        /// </summary>
        [JsonPropertyName("voucher_consult_list")]
        public List<VoucherConsultInfo> VoucherConsultList { get; set; }
    }
}
