using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionChannelBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }
    }
}
