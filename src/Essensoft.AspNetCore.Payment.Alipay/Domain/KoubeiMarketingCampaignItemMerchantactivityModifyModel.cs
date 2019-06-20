using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityModifyModel : AlipayObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部回调地址
        /// </summary>
        [JsonProperty("external_callback_url")]
        public string ExternalCallbackUrl { get; set; }

        /// <summary>
        /// 活动结束日期，只可以延长  格式要求为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动商品列表，只可以增加
        /// </summary>
        [JsonProperty("item_ids")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 券信息，可修改logo/userIntroductions ，validTimeRangeTo只可延长，validDaysRangeTo只可延长
        /// </summary>
        [JsonProperty("voucher_info")]
        public MerchantActivityModifyVoucherInfo VoucherInfo { get; set; }
    }
}
