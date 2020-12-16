using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacepayCloseResponse.
    /// </summary>
    public class AlipayCommerceEducateFacepayCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 关闭申请执行结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
