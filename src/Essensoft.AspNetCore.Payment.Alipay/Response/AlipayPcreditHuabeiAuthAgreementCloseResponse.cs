using Newtonsoft.Json;

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
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
