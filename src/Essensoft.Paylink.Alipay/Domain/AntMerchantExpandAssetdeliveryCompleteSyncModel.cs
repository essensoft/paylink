using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryCompleteSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetdeliveryCompleteSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送完成反馈信息
        /// </summary>
        [JsonPropertyName("asset_delivery_details")]
        public List<AssetDeliveryDetail> AssetDeliveryDetails { get; set; }
    }
}
