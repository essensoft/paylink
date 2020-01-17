using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoFilePathQueryResponse.
    /// </summary>
    public class AlipayEcoFilePathQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 文件Id
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件直传地址, 可以重复使用，但是只能传一样的文件，有效期一小时
        /// </summary>
        [JsonPropertyName("upload_url")]
        public string UploadUrl { get; set; }
    }
}
