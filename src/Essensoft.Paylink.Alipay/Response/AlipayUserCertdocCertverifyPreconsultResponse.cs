using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertdocCertverifyPreconsultResponse.
    /// </summary>
    public class AlipayUserCertdocCertverifyPreconsultResponse : AlipayResponse
    {
        /// <summary>
        /// 申请验证ID
        /// </summary>
        [JsonPropertyName("verify_id")]
        public string VerifyId { get; set; }
    }
}
