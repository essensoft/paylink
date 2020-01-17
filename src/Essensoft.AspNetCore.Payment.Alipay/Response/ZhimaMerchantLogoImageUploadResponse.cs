using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantLogoImageUploadResponse.
    /// </summary>
    public class ZhimaMerchantLogoImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上传图片后生成的图片地址
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }
    }
}
