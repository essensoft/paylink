using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryCompleteSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetdeliveryCompleteSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 配送反馈处理结果
        /// </summary>
        [JsonPropertyName("delivery_results")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
