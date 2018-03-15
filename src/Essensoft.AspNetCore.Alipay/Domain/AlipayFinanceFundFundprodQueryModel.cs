using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundprodQueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceFundFundprodQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [JsonProperty("fund_code")]
        public string FundCode { get; set; }
    }
}
