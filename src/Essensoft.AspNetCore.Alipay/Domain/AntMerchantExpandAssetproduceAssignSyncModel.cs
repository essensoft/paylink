using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetproduceAssignSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetproduceAssignSyncModel : AlipayObject
    {
        /// <summary>
        /// 生产指令接收情况，最多200条
        /// </summary>
        [JsonProperty("asset_results")]
        public List<AssetResult> AssetResults { get; set; }
    }
}
