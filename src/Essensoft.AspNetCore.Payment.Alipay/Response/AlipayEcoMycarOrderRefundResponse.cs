using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarOrderRefundResponse.
    /// </summary>
    public class AlipayEcoMycarOrderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonPropertyName("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 是否成功(T: 成功，F:失败)
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
