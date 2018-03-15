using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryAssignSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetdeliveryAssignSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送指令接收反馈，最多200条
        /// </summary>
        [JsonProperty("delivery_results")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
