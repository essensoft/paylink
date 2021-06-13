using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoApplogoUploadResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoApplogoUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上传图片结果地址。 图片要求： 1、不能超过256kb 2、支持的图片格式为jpg、jpeg、png 3、长宽比例必须为为1:1
        /// </summary>
        [JsonPropertyName("app_logo")]
        public string AppLogo { get; set; }
    }
}
