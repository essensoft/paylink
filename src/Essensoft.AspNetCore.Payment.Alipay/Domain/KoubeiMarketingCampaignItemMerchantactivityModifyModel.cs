using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityModifyModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityModifyModel : AlipayObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部回调地址
        /// </summary>
        [JsonPropertyName("external_callback_url")]
        public string ExternalCallbackUrl { get; set; }

        /// <summary>
        /// 活动结束日期，只可以延长  格式要求为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动商品列表，只可以增加
        /// </summary>
        [JsonPropertyName("item_ids")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 券信息，可修改logo/userIntroductions ，validTimeRangeTo只可延长，validDaysRangeTo只可延长
        /// </summary>
        [JsonPropertyName("voucher_info")]
        public MerchantActivityModifyVoucherInfo VoucherInfo { get; set; }
    }
}
