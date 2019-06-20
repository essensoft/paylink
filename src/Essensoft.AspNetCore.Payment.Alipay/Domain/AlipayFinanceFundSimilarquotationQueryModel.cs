using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceFundSimilarquotationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceFundSimilarquotationQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [JsonProperty("fund_code")]
        public string FundCode { get; set; }
    }
}
