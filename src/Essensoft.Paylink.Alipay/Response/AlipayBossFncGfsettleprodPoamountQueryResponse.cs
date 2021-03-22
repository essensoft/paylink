using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodPoamountQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodPoamountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 已开票金额
        /// </summary>
        [JsonPropertyName("po_invoiced_amount")]
        public MultiCurrencyMoneyOpenApi PoInvoicedAmount { get; set; }

        /// <summary>
        /// 已认证开票金额
        /// </summary>
        [JsonPropertyName("po_invoiced_auth_amount")]
        public MultiCurrencyMoneyOpenApi PoInvoicedAuthAmount { get; set; }

        /// <summary>
        /// 已付款金额
        /// </summary>
        [JsonPropertyName("po_settled_amount")]
        public MultiCurrencyMoneyOpenApi PoSettledAmount { get; set; }
    }
}
