using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandExpressChangeSyncResponse.
    /// </summary>
    public class AntMerchantExpandExpressChangeSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [JsonPropertyName("upload_result")]
        public AssetResult UploadResult { get; set; }
    }
}
