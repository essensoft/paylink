using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvchannelBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionAdvchannelBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 广告ID
        /// </summary>
        [JsonPropertyName("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页记录数，默认10，最大100
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }
    }
}
