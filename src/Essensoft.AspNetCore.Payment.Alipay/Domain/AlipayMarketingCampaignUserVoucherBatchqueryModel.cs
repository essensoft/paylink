using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
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
    }
}
