using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoPaysignConfirmResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoPaysignConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 协议单号
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }
    }
}
