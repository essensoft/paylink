using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandDeliveryProcessSyncResponse.
    /// </summary>
    public class AntMerchantExpandDeliveryProcessSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [JsonPropertyName("result")]
        public AssetResult Result { get; set; }
    }
}
