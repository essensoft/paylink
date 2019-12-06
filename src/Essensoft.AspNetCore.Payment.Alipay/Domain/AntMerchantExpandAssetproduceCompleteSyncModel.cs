using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetproduceCompleteSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetproduceCompleteSyncModel : AlipayObject
    {
        /// <summary>
        /// 物料生产单完成后指定物流信息
        /// </summary>
        [JsonPropertyName("asset_produce_details")]
        public List<ItemDeliveryDetail> AssetProduceDetails { get; set; }
    }
}
