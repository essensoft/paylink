using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertifyImgUploadResponse.
    /// </summary>
    public class AlipayUserCertifyImgUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片上传成功后，返回的图片地址
        /// </summary>
        [JsonPropertyName("pic_url")]
        public string PicUrl { get; set; }
    }
}
