using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerCertificationMaterialCertifyResponse.
    /// </summary>
    public class ZhimaCustomerCertificationMaterialCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 本次认证的唯一标识，商户需要记录，后续的操作都需要用到
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 认证不通过的原因
        /// </summary>
        [JsonPropertyName("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证是否通过,通过为true，不通过为false
        /// </summary>
        [JsonPropertyName("passed")]
        public string Passed { get; set; }
    }
}
