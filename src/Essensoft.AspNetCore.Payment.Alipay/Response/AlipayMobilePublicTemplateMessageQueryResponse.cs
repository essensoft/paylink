using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicTemplateMessageQueryResponse.
    /// </summary>
    public class AlipayMobilePublicTemplateMessageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果值
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
