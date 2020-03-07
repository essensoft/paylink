using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertifyIdentifyVerifyResponse.
    /// </summary>
    public class AlipayUserCertifyIdentifyVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 校验结果，T表示满足条件，F表示不满足条件
        /// </summary>
        [JsonPropertyName("biz_code_status")]
        public string BizCodeStatus { get; set; }
    }
}
