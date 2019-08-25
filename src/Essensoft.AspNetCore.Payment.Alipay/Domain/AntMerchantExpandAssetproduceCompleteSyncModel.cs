using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetproduceCompleteSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetproduceCompleteSyncModel : AlipayObject
    {
        /// <summary>
        /// 物料生产单完成后指定物流信息
        /// </summary>
        [JsonProperty("asset_produce_details")]
        public List<ItemDeliveryDetail> AssetProduceDetails { get; set; }
    }
}
