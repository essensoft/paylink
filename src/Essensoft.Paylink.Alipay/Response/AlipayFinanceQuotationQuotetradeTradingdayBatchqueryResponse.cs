using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeTradingdayBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeTradingdayBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易日数据, 格式为 yyyyMMdd. 逆序排序
        /// </summary>
        [JsonPropertyName("data")]
        public List<string> Data { get; set; }
    }
}
