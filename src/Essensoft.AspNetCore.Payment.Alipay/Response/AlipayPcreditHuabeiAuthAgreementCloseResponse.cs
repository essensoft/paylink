using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthAgreementCloseResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthAgreementCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
