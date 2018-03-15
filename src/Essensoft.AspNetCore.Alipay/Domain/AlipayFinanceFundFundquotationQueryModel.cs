using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundquotationQueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceFundFundquotationQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金编号：基金产品编号
        /// </summary>
        [JsonProperty("fund_code")]
        public string FundCode { get; set; }
    }
}
