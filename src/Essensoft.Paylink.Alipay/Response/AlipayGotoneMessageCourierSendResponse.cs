using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayGotoneMessageCourierSendResponse.
    /// </summary>
    public class AlipayGotoneMessageCourierSendResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码。SUCCESS：发送成功。
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
