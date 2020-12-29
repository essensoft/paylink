using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappBrandUploadResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappBrandUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片上传成功后的图片存储键(可用于填写调用alipay.open.mini.miniapp.brand.submit时需要的图片类型的字段)
        /// </summary>
        [JsonPropertyName("file_key")]
        public string FileKey { get; set; }
    }
}
