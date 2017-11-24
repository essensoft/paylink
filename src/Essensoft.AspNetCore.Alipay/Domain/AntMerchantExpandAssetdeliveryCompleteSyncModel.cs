using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryCompleteSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetdeliveryCompleteSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送完成反馈信息
        /// </summary>
        [JsonProperty("asset_delivery_details")]
        public List<AssetDeliveryDetail> AssetDeliveryDetails { get; set; }
    }
}
