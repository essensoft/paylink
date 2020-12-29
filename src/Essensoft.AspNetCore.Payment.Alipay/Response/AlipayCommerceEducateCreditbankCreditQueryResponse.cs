using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankCreditQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankCreditQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 学分信息
        /// </summary>
        [JsonPropertyName("credit")]
        public List<CreditBankCredit> Credit { get; set; }
    }
}
