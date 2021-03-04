using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
