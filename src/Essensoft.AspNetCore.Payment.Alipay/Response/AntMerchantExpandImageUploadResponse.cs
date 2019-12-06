using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandImageUploadResponse.
    /// </summary>
    public class AntMerchantExpandImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片在sfs中的标识
        /// </summary>
        [JsonPropertyName("image_id")]
        public string ImageId { get; set; }
    }
}
