using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelExchangerateBatchqueryResponse.
    /// </summary>
    public class AlipayOverseasTravelExchangerateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇率描述
        /// </summary>
        [JsonPropertyName("rate_desc")]
        public string RateDesc { get; set; }

        /// <summary>
        /// 汇率来源说明
        /// </summary>
        [JsonPropertyName("rate_source")]
        public string RateSource { get; set; }

        /// <summary>
        /// 多个币种汇率结果，currency:货币代码，ISO标准alpha- 3币种代码;  rate:当前币种/CNY的汇率,Number(15,8)  currency_icon:货币图片的url地址
        /// </summary>
        [JsonPropertyName("rates")]
        public List<OverseasTravelRate> Rates { get; set; }
    }
}
