using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryCompleteSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetdeliveryCompleteSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送完成反馈信息
        /// </summary>
        [JsonProperty("asset_delivery_details")]
        public List<AssetDeliveryDetail> AssetDeliveryDetails { get; set; }
    }
}
