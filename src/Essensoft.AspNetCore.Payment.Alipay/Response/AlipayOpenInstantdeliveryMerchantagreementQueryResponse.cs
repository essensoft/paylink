using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantagreementQueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantagreementQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 物流代扣协议的详细内容
        /// </summary>
        [JsonPropertyName("agreement_detail")]
        public AgreementDetail AgreementDetail { get; set; }
    }
}
