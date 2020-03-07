using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppProdmodeAgreementUploadResponse.
    /// </summary>
    public class AlipayEbppProdmodeAgreementUploadResponse : AlipayResponse
    {
        /// <summary>
        /// true:表示上传文件成功  false:表示上传文件失败
        /// </summary>
        [JsonPropertyName("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 上传文件成功备注说明。
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }
    }
}
