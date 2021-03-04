using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserInvitetaskExchangeConsultResponse.
    /// </summary>
    public class AlipayUserInvitetaskExchangeConsultResponse : AlipayResponse
    {
        /// <summary>
        /// true--有兑换资格  false--无兑换资格
        /// </summary>
        [JsonPropertyName("consult_result")]
        public bool ConsultResult { get; set; }
    }
}
