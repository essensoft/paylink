using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoApplogoUploadResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoApplogoUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上传图片结果地址
        /// </summary>
        [JsonPropertyName("app_logo")]
        public string AppLogo { get; set; }
    }
}
