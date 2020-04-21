using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitSendResponse.
    /// </summary>
    public class KoubeiMarketingCampaignBenefitSendResponse : AlipayResponse
    {
        /// <summary>
        /// 领取的权益列表
        /// </summary>
        [JsonPropertyName("benefit_ids")]
        public List<string> BenefitIds { get; set; }

        /// <summary>
        /// 发放券展示模型
        /// </summary>
        [JsonPropertyName("voucher_vo_list")]
        public List<VoucherVO> VoucherVoList { get; set; }

        /// <summary>
        /// 发放券展示模型（该字段已废弃）
        /// </summary>
        [JsonPropertyName("voucher_vos")]
        public VoucherVO VoucherVos { get; set; }
    }
}
