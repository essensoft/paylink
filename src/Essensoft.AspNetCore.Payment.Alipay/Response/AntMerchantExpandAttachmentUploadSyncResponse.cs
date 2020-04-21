using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandAttachmentUploadSyncResponse.
    /// </summary>
    public class AntMerchantExpandAttachmentUploadSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [JsonPropertyName("upload_result")]
        public AssetResult UploadResult { get; set; }
    }
}
