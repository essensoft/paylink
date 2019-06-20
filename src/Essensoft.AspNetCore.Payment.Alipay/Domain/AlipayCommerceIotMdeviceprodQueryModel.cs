using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备id（物料系统的id）
        /// </summary>
        [JsonProperty("asset_id")]
        public string AssetId { get; set; }
    }
}
