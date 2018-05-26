using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        [XmlArray("asset_produce_details")]
        [XmlArrayItem("item_delivery_detail")]
        public List<ItemDeliveryDetail> AssetProduceDetails { get; set; }
    }
}
