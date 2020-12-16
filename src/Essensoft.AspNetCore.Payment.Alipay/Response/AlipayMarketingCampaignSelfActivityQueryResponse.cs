using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSelfActivityQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSelfActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// b.alipay.com 自营销活动的活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 当前状态，同商家自运营后台显示活动状态，已创建、已发布、已暂停、已结束
        /// </summary>
        [JsonPropertyName("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 券模板列表
        /// </summary>
        [JsonPropertyName("voucher_template_list")]
        public List<VoucherTemplate> VoucherTemplateList { get; set; }
    }
}
