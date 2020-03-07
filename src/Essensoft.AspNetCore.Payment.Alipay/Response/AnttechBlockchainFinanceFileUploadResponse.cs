using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFileUploadResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFileUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上传成功后返回文件信息
        /// </summary>
        [JsonPropertyName("file_info")]
        public FinanceFileInfo FileInfo { get; set; }
    }
}
