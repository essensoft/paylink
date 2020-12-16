using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappBrandUploadResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappBrandUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片上传成功后的地址
        /// </summary>
        [JsonPropertyName("file_key")]
        public string FileKey { get; set; }
    }
}
