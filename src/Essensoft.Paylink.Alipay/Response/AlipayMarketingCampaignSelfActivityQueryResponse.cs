using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSelfActivityQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSelfActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动结束时间，即券可领取结束时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("activity_end_time")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// b.alipay.com 自营销活动的活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动开始时间，即券可领取开始时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 当前状态，同商家自运营后台显示活动状态，已创建、已发布、已暂停、已结束
        /// </summary>
        [JsonPropertyName("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [JsonPropertyName("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 券模板列表
        /// </summary>
        [JsonPropertyName("voucher_template_list")]
        public List<VoucherTemplate> VoucherTemplateList { get; set; }
    }
}
