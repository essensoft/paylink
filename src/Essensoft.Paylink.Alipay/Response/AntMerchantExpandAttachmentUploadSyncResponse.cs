using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
