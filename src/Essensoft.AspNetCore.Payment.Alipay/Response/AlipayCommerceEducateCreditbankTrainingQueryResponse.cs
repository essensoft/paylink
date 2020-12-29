using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankTrainingQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankTrainingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 培训记录
        /// </summary>
        [JsonPropertyName("training")]
        public List<CreditBankTraining> Training { get; set; }
    }
}
