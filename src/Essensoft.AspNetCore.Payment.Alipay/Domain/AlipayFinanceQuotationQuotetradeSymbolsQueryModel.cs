using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSymbolsQueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSymbolsQueryModel : AlipayObject
    {
        /// <summary>
        /// 股票市场,多个市场按逗号分隔
        /// </summary>
        [JsonPropertyName("market")]
        public string Market { get; set; }

        /// <summary>
        /// 股票子类型，支持批量，多个子类型用逗号分隔，参考：https://yuque.antfin-inc.com/finquot/wgciv0/ehvgvu
        /// </summary>
        [JsonPropertyName("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 股票类型，如股票型(ES)、债券(D)、场内基金(EU),支持批量，多个类型按逗号分隔
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
