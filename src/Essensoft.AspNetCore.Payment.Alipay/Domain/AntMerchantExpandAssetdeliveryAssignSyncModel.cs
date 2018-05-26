using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        [XmlArray("delivery_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
