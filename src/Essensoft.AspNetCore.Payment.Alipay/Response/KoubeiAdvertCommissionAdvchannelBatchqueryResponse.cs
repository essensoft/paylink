using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvchannelBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionAdvchannelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务数据
        /// </summary>
        [JsonPropertyName("data")]
        public List<KbAdvertAdvChannelResponse> Data { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [JsonPropertyName("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页记录数，默认10，最大100
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
