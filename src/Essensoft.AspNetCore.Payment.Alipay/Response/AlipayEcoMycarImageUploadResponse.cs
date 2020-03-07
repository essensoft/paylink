using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarImageUploadResponse.
    /// </summary>
    public class AlipayEcoMycarImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片Id
        /// </summary>
        [JsonPropertyName("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 图片地址，url全是小写
        /// </summary>
        [JsonPropertyName("img_url")]
        public string ImgUrl { get; set; }
    }
}
