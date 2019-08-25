using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryAssignSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetdeliveryAssignSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送指令接收反馈，最多200条
        /// </summary>
        [JsonProperty("delivery_results")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
