using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinanceFundFundnetvaluesBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceFundFundnetvaluesBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }

        /// <summary>
        /// 基金类型，如：STOCK，BLEND，INDEX，BOND，CURRENCY，QDII，SHORTDATED，FOF
        /// </summary>
        [JsonPropertyName("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 基金净值列表
        /// </summary>
        [JsonPropertyName("net_values")]
        public List<NetValueVO> NetValues { get; set; }
    }
}
