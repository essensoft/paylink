using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertifyOpenInitializeResponse.
    /// </summary>
    public class AlipayUserCertifyOpenInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 本次申请操作的唯一标识，商户需要记录，后续的操作都需要用到
        /// </summary>
        [JsonPropertyName("certify_id")]
        public string CertifyId { get; set; }
    }
}
