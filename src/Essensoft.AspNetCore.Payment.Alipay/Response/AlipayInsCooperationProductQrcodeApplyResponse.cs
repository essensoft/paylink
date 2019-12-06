using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsCooperationProductQrcodeApplyResponse.
    /// </summary>
    public class AlipayInsCooperationProductQrcodeApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 快捷投保产品二维码图片链接URL
        /// </summary>
        [JsonPropertyName("code_url")]
        public string CodeUrl { get; set; }
    }
}
