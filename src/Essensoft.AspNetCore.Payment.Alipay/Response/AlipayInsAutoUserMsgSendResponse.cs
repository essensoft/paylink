using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoUserMsgSendResponse.
    /// </summary>
    public class AlipayInsAutoUserMsgSendResponse : AlipayResponse
    {
        /// <summary>
        /// 描述是否可以重试
        /// </summary>
        [JsonPropertyName("can_retry")]
        public bool CanRetry { get; set; }
    }
}
