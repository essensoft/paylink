using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeBankRootQueryResponse.
    /// </summary>
    public class MybankPaymentTradeBankRootQueryResponse : AlipayResponse
    {
        /// <summary>
        /// Institution列表
        /// </summary>
        [JsonPropertyName("bank_details")]
        public List<Institution> BankDetails { get; set; }
    }
}
