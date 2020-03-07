using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundquotationQueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceFundFundquotationQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金编号：基金产品编号
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }
    }
}
