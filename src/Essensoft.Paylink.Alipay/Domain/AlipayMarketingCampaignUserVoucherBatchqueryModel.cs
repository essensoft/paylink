using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 分页查询的当前页号,从1开始
        /// </summary>
        [JsonPropertyName("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 分页查询的单页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 券状态： 可用(ENABLED)，已核销(即完全使用，USED)，已过期(EXPIRED)，不可用(DISABLED)
        /// </summary>
        [JsonPropertyName("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
