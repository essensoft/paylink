using System.Text.Json.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdGfsettleprodApplyQueryResponse.
    /// </summary>
    public class AlipayBossProdGfsettleprodApplyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 付款（开票）申请
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<PaymentApplyResponseDTO> ResultSet { get; set; }
    }
}
