using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundFixedprofitQueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceFundFundFixedprofitQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [JsonProperty("fund_code")]
        public string FundCode { get; set; }
    }
}
