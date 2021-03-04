using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertDataPromotesummaryDateBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertDataPromotesummaryDateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑客推广日期维度汇总数据
        /// </summary>
        [JsonPropertyName("data")]
        public List<PromoteDateModel> Data { get; set; }
    }
}
