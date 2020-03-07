using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionChannelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 渠道信息
        /// </summary>
        [JsonPropertyName("data")]
        public KbAdvertChannelResponse Data { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页页数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }
    }
}
