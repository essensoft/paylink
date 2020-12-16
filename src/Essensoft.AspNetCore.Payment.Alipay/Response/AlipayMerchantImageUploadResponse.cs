using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantImageUploadResponse.
    /// </summary>
    public class AlipayMerchantImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片在文件存储平台的标识
        /// </summary>
        [JsonPropertyName("image_id")]
        public string ImageId { get; set; }
    }
}
