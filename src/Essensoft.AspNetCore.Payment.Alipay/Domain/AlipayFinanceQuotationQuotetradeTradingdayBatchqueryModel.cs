using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeTradingdayBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeTradingdayBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询的开始日期, 格式为 yyyyMMdd
        /// </summary>
        [JsonPropertyName("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 查询的结束日期, 日式为 yyyyMMdd
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 市场, 查询该市场的交易日
        /// </summary>
        [JsonPropertyName("market")]
        public string Market { get; set; }
    }
}
