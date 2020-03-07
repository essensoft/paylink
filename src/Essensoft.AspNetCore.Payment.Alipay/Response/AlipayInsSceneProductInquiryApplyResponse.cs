using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneProductInquiryApplyResponse.
    /// </summary>
    public class AlipayInsSceneProductInquiryApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 保险产品保费值，金额类型(单位为分)
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }
    }
}
