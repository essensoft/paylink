using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureInfoSendResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureInfoSendResponse : AlipayResponse
    {
        /// <summary>
        /// 返回更新失败的userId集合
        /// </summary>
        [JsonPropertyName("error_uids")]
        public string ErrorUids { get; set; }
    }
}
