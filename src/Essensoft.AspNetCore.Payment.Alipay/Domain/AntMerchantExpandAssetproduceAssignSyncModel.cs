using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetproduceAssignSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetproduceAssignSyncModel : AlipayObject
    {
        /// <summary>
        /// 生产指令接收情况，最多200条
        /// </summary>
        [JsonProperty("asset_results")]
        [XmlArray("asset_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> AssetResults { get; set; }
    }
}
