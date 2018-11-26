using System;
using System.Collections.Generic;
using System.Xml.Serialization;
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
        [XmlArray("asset_delivery_details")]
        [XmlArrayItem("asset_delivery_detail")]
        public List<AssetDeliveryDetail> AssetDeliveryDetails { get; set; }
    }
}
