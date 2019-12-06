using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetproduceAssignSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetproduceAssignSyncModel : AlipayObject
    {
        /// <summary>
        /// 生产指令接收情况，最多200条
        /// </summary>
        [JsonPropertyName("asset_results")]
        public List<AssetResult> AssetResults { get; set; }
    }
}
