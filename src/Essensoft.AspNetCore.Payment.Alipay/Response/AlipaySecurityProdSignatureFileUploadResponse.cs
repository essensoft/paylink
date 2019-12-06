using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdSignatureFileUploadResponse.
    /// </summary>
    public class AlipaySecurityProdSignatureFileUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 文件唯一标识，用于apply接口传入
        /// </summary>
        [JsonPropertyName("oss_file_id")]
        public string OssFileId { get; set; }
    }
}
